using OpenQA.Selenium;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests.Demobank;

public class DemobankCommonActions
{
    IWebDriver _driver;
    By LoginLocator => By.Id("login_id");
    By PasswordLocator => By.Id("login_password");
    By LoginBtnLocator => By.Id("login-btn");

    public DemobankCommonActions(IWebDriver driver)
    {
        _driver = driver;
    }

    public void Login(string username, string password)
    {
        _driver.FindElement(LoginLocator).SendKeys(username);
        _driver.FindElement(PasswordLocator).SendKeys(password);
        _driver.FindElement(LoginBtnLocator).Click();
    }
}
