using OpenQA.Selenium;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests.Demobank;

public class DemobankLoginTests : BaseTest
{
    By LoginLocator => By.Id("user-name");
    By PasswordLocator => By.Id("password");
    By LoginBtnLocator => By.Id("login-btn");

    [Test]
    public void Verify_UserCanLogIn_When_CredentialsAreValid()
    {
        OpenDemobankLoginPage();
        WebDriver.FindElement(LoginLocator).SendKeys("username");
        WebDriver.FindElement(PasswordLocator).SendKeys("password");
        WebDriver.FindElement(LoginBtnLocator).Click();
    }
}
