using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests;

public class BaseTest
{
    public IWebDriver WebDriver { get; set; }

    [SetUp]
    public void BaseSetUp()
    {
        WebDriver = new ChromeDriver();
    }

    [TearDown]
    public void BaseTearDown()
    {
        WebDriver.Quit();
        WebDriver.Dispose();
    }

    protected void OpenDemobankLoginPage()
    {
        WebDriver.Navigate().GoToUrl("https://demo-bank.vercel.app/index.html");
    }
}
