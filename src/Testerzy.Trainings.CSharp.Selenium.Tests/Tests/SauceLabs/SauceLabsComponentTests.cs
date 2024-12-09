using Allure.NUnit;
using Testerzy.Trainings.CSharp.Selenium.Demobank.Pages.SauceDemo;
using Testerzy.Trainings.CSharp.Selenium.Framework;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests.SauceLabs;

[AllureNUnit]
public class SauceLabsComponentTests : BaseSauceDemoTest
{
    [Test]
    public void TestProductComponents()
    {
        var loginPage = new LoginPage(WebDriver);
        var productsPage = loginPage.Login(Constants.SauceLabs.ValidUsername, Constants.SauceLabs.ValidPassword);

        var thirdProduct = productsPage.GetProducts()[2];
        thirdProduct.AddToCart();

        var fleeceJacketProduct = productsPage.GetProduct("Sauce Labs Fleece Jacket");
        fleeceJacketProduct.AddToCart();

        Assert.That(productsPage.GetProductInCartCount(), Is.EqualTo(2));
    }

    [Test]
    public void TestProductComponents_Property()
    {
        var loginPage = new LoginPage(WebDriver);
        var productsPage = loginPage.Login(Constants.SauceLabs.ValidUsername, Constants.SauceLabs.ValidPassword);

        var thirdProduct = productsPage.Products[2];
        thirdProduct.AddToCart();

        productsPage.Products[0].AddToCart();

        var fleeceJacketProduct = productsPage.GetProduct("Sauce Labs Fleece Jacket");
        fleeceJacketProduct.AddToCart();

        Assert.That(productsPage.GetProductInCartCount(), Is.EqualTo(3));
    }
}
