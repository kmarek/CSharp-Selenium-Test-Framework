using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank;

public class BaseSauceDemoTest
{
    protected IWebDriver WebDriver { get; set; }

    [SetUp]
    public void BaseSetUp()
    {
        WebDriver = new ChromeDriver();
        WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        OpenSauceDemoPage();
    }

    [TearDown]
    public void BaseTearDown()
    {
        WebDriver.Quit();
        WebDriver.Dispose();
    }

    protected void OpenSauceDemoPage()
    {
        WebDriver.Navigate().GoToUrl("https://www.saucedemo.com/");
    }
}
