using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Testerzy.Trainings.CSharp.Selenium.Demobank.Labs.Pages;
using OpenQA.Selenium.Support.UI;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Labs.Tests;

public class BaseTest
{
    protected IWebDriver WebDriver { get; set; }
    protected WebDriverWait Wait { get; set; }

    [SetUp]
    public void BaseSetUp()
    {
        WebDriver = new ChromeDriver();
        Wait = new(WebDriver, TimeSpan.FromSeconds(5));
        Wait.PollingInterval = TimeSpan.FromMilliseconds(250);
        Wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
    }

    [TearDown]
    public void BaseTearDown()
    {
        WebDriver.Quit();
        WebDriver.Dispose();
    }

    protected LoginPage OpenDemobankLoginPage()
    {
        WebDriver.Navigate().GoToUrl("https://demo-bank.vercel.app/index.html");
        return new(WebDriver);
    }
}
