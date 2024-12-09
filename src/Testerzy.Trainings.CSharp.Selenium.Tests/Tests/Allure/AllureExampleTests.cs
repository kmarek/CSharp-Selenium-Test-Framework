using Allure.NUnit;
using Testerzy.Trainings.CSharp.Selenium.Demobank.Pages.SauceDemo;
using Testerzy.Trainings.CSharp.Selenium.Framework;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests.Allure;

[AllureNUnit]
public class AllureExampleTests : BaseSauceDemoTest
{
    [Test]
    public void VerifyValidUserCanLogIn()
    {
        var loginPage = new LoginPage(WebDriver);
        var productsPage = loginPage.Login(Constants.SauceLabs.ValidUsername, Constants.SauceLabs.ValidPassword);

        Assert.That(productsPage.GetProducts().Count, Is.EqualTo(6));
    }

    [Test]
    public void VerifyValidUserCanLogIn1()
    {
        var loginPage = new LoginPage(WebDriver);
        var productsPage = loginPage.Login(Constants.SauceLabs.ValidUsername, Constants.SauceLabs.ValidPassword);

        Assert.That(productsPage.GetProducts().Count, Is.EqualTo(6));
    }

    [Test]
    public void VerifyValidUserCanLogIn2()
    {
        var loginPage = new LoginPage(WebDriver);
        var productsPage = loginPage.Login(Constants.SauceLabs.ValidUsername, Constants.SauceLabs.ValidPassword);

        Assert.That(productsPage.GetProducts().Count, Is.EqualTo(6));
    }
}
