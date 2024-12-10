using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Testerzy.Trainings.CSharp.Selenium.Demobank.Labs.Pages;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Labs.Tests;

public class BaseTest
{
    protected IWebDriver WebDriver { get; set; }

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

    protected LoginPage OpenDemobankLoginPage()
    {
        WebDriver.Navigate().GoToUrl("https://demo-bank.vercel.app/index.html");
        return new(WebDriver);
    }
}
