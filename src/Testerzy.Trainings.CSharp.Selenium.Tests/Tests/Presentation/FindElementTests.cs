using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests.Presentation;

public class FindElementTests : BaseSauceDemoTest
{
    [Test]
    public void FindElementOnDriver()
    {
        IWebElement container = WebDriver.FindElement(By.CssSelector(".login_container"));
        IWebElement boxInsideContainer = container.FindElement(By.CssSelector(".login-box"));
    }

    [Test]
    public void FindNotExistingElement()
    {
        IWebElement notFound = WebDriver.FindElement(By.CssSelector(".not-existing-class"));
    }

    [Test]
    public void FindElements()
    {
        ReadOnlyCollection<IWebElement> elements = WebDriver.FindElements(By.CssSelector(".item"));

        IWebElement firstElement = elements.First();
        ReadOnlyCollection<IWebElement> elementsInFirstElement = firstElement
            .FindElements(By.CssSelector(".description"));
    }

    [Test]
    public void FindNotExistingElements()
    {
        ReadOnlyCollection<IWebElement> notFoundList = WebDriver.FindElements(By.CssSelector(".not-existing-class"));

        Console.WriteLine($"Found {notFoundList.Count} elements");
    }

    [TestCase(".login-box")]
    [TestCase(".login")]
    [TestCase(".log")]
    public void ByCssLocatorLocators(string searchString)
    {
        By className = By.Id(searchString);

        var elements = WebDriver.FindElements(className);
        Console.WriteLine($"Found {elements.Count} elements by className={searchString}");
    }

    [TestCase("login-box")]
    [TestCase("login")]
    [TestCase("log")]
    public void ByClassNameLocators(string searchString)
    {
        By className = By.ClassName(searchString);

        var elements = WebDriver.FindElements(className);
        Console.WriteLine($"Found {elements.Count} elements by className={searchString}");
    }

    [TestCase(".login-box")]
    [TestCase("[data-test=login-button]")]
    [TestCase("[data-test='login-button']")]
    [TestCase("form")]
    [TestCase("input")]
    [TestCase("li")]
    public void ByCssLocator(string searchString)
    {
        By className = By.CssSelector(searchString);

        var elements = WebDriver.FindElements(className);
        Console.WriteLine($"Found {elements.Count} elements by CssLocator={searchString}");
    }

    [TestCase("login-button")]
    [TestCase("password")]
    [TestCase("user-name")]
    public void ByNameLocator(string searchString)
    {
        By className = By.Name(searchString);

        var elements = WebDriver.FindElements(className);
        Console.WriteLine($"Found {elements.Count} elements by Name={searchString}");
    }

    [TestCase("form")]
    [TestCase("input")]
    [TestCase("li")]
    public void ByTagNameLocator(string searchString)
    {
        By className = By.TagName(searchString);

        var elements = WebDriver.FindElements(className);
        Console.WriteLine($"Found {elements.Count} elements by TagName={searchString}");
    }

    [TestCase("/html/body/div/div/div[2]/div[1]/div/div/form/div[1]/input")]
    [TestCase("//*[@id=\"user-name\"]")]
    public void ByXPathLocator(string searchString)
    {
        By className = By.XPath(searchString);

        var elements = WebDriver.FindElements(className);
        Console.WriteLine($"Found {elements.Count} elements by XPath={searchString}");
    }

    [TestCase("Finding element")]
    public void ByLinkTextLocator(string searchString)
    {
        WebDriver.Navigate().GoToUrl("https://www.selenium.dev/documentation/webdriver/elements/locators/");

        By locator = By.LinkText(searchString);

        var elements = WebDriver.FindElements(locator);
        Console.WriteLine($"Found {elements.Count} elements by LinkText={searchString}");
    }

    [TestCase("Finding element")]
    [TestCase("ding")]
    [TestCase("element")]
    public void ByPartialLinkTextLocator(string searchString)
    {
        WebDriver.Navigate().GoToUrl("https://www.selenium.dev/documentation/webdriver/elements/locators/");

        By locator = By.PartialLinkText(searchString);

        var elements = WebDriver.FindElements(locator);
        Console.WriteLine($"Found {elements.Count} elements by PartialLinkText={searchString}");
    }
}
