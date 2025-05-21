using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Labs.Tests;

public class DemobankSimpleTests : BaseTest
{
    [Test]
    public void Verify_ChartIsVisible()
    {
        By loginLocator = By.Id("login_id");
        By passwordLocator = By.Id("login_password");
        By loginBtnLocator = By.Id("login-btn");

        WebDriver.Navigate().GoToUrl("https://demo-bank.vercel.app/index.html");

        WebDriver.FindElement(loginLocator).SendKeys("username");
        WebDriver.FindElement(passwordLocator).SendKeys("password");
        WebDriver.FindElement(loginBtnLocator).Click();

        By financeManagerLocator = By.Id("manager_fin_btn");
        WebDriver.FindElement(financeManagerLocator).Click();

        By chartWidgetLocator = By.Id("widget_financial_manager_1");
        bool isVisible = Wait.Until(d => d.FindElement(chartWidgetLocator).Enabled);

        Assert.That(isVisible, Is.True);

        //
        bool element = Wait.Until(ExpectedConditions.ElementIsVisible(chartWidgetLocator)).Enabled;
        Assert.That(element, Is.True);
    }
}
