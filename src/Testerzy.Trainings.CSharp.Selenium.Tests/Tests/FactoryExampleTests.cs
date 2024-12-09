using OpenQA.Selenium;
using Testerzy.Trainings.CSharp.Selenium.Configuration.Models;
using Testerzy.Trainings.CSharp.Selenium.Framework.BusinessModels;
using Testerzy.Trainings.CSharp.Selenium.Framework.Factories;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests;

[Parallelizable(ParallelScope.Self)]
public class FactoryExampleTests
{
    [Test]
    public void Verify_AdminDashboardIsDisplayed()
    {
        Account adminUser = new()
        {
            Username = "Johnny the Admin",
            FirstName = "John",
            LastName = "Doe",
            BankAccount = new()
            {
                AccountNumber = "PL 1234 4321 1234"
            },
            Permissions = new()
            {
                new Permission("Admin", "ADM", "ALL"),
                new Permission("Accounts-Read", "ACCREAD", "INTERNAL")
            }
        };

        // login and perform other steps
    }

    [Test]
    public void Verify_AdminDashboardIsDisplayed1()
    {
        Account admin = AccountFactory.CreateAdmin();

        // login and perform other steps
    }

    [Test]
    public void Verify_BrowserType()
    {
        BrowserName browserNameFromConfig = Settings.BrowserName;

        IWebDriver webDriver = WebDriverFactory.Create(browserNameFromConfig);
        webDriver.Navigate().GoToUrl("https://testerzy.pl");
        webDriver.FindElement(By.Id("cookieLawModal-accept")).Click();
        webDriver.Quit();
    }

    private Settings Settings { get; set; } = new() { BrowserName = BrowserName.Edge };
}
