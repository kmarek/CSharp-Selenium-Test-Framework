using OpenQA.Selenium;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Labs.Pages;

public class LoginPage : BasePage
{
    By LoginLocator => By.Id("login_id");
    By PasswordLocator => By.Id("login_password");
    By LoginBtnLocator => By.Id("login-btn");

    public LoginPage(IWebDriver driver) : base(driver)
    {
    }

    public MyDesktopPage LoginSuccessfully(string username, string password)
    {
        Driver.FindElement(LoginLocator).SendKeys(username);
        Driver.FindElement(PasswordLocator).SendKeys(password);
        Driver.FindElement(LoginBtnLocator).Click();

        return new MyDesktopPage(Driver);
    }
}
