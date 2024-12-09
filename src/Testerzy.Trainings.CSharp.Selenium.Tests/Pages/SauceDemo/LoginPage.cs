using OpenQA.Selenium;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Pages.SauceDemo;

public class LoginPage : BasePage
{
    protected By UsernameLocator => By.Id("user-name");
    protected By PasswordLocator => By.Id("password");
    protected By LoginBtnLocator => By.CssSelector("[data-test=login-button]");

    public LoginPage(IWebDriver driver) : base(driver) { }

    public ProductsPage Login(string username, string password)
    {
        Driver.FindElement(UsernameLocator).SendKeys(username);
        Driver.FindElement(PasswordLocator).SendKeys(password);
        Driver.FindElement(LoginBtnLocator).Click();

        return new ProductsPage(Driver);
    }
}
