using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests.Presentation;

public class InteractionsTests : BaseSauceDemoTest
{
    [Test]
    public void ClickTest()
    {
        IWebElement loginBtn = WebDriver.FindElement(By.Id("login-button"));
        loginBtn.Click();

        IWebElement username = WebDriver.FindElement(By.Id("user-name"));
        username.SendKeys("username");
        username.Clear();
    }

    [Test]
    public void ActionsApiTest()
    {
        IWebElement clickable = WebDriver.FindElement(By.Id("user-name"));
        new Actions(WebDriver)
            .MoveToElement(clickable)
            .Pause(TimeSpan.FromSeconds(1))
            .ClickAndHold()
            .Pause(TimeSpan.FromSeconds(1))
            .SendKeys("abc")
            .Perform();
    }

    [Test, Ignore("no scenario")]
    public void DragAndDropTest()
    {
        IWebElement draggable = WebDriver.FindElement(By.Id("draggable"));
        IWebElement droppable = WebDriver.FindElement(By.Id("droppable"));
        new Actions(WebDriver)
            .DragAndDrop(draggable, droppable)
            .Perform();
    }

    [Test]
    public void WebDriverOperations()
    {
        WebDriver.Navigate().GoToUrl("http://testerzy.pl");
        WebDriver.Navigate().Refresh();
    }

    [Test]
    public void WebElementOperations()
    {
        IWebElement username = WebDriver.FindElement(By.Id("user-name"));
        bool isDisplayed = username.Displayed;
        bool isEnabled = username.Enabled;
        bool isSelected = username.Selected; // checkbox, radiobutton itp
        string contentText = username.Text;

        string valueText = username.GetDomAttribute("autocorrect");
        Console.WriteLine(valueText);
    }
}
