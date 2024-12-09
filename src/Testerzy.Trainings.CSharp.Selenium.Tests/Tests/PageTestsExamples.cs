using Testerzy.Trainings.CSharp.Selenium.Demobank.Pages.SauceDemo;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests;

public class PageTestsExamples : BaseTest
{
    [Test]
    public void TestSauceLogin()
    {
        WebDriver.Navigate().GoToUrl("https://www.saucedemo.com/");

        var loginPage = new LoginPage(WebDriver);
        var productsPage = loginPage.Login("standard_user", "secret_sauce");
        // kolejne kroki
    }
}
