using Testerzy.Trainings.CSharp.Selenium.Configuration;
using Testerzy.Trainings.CSharp.Selenium.Configuration.Models;
using Testerzy.Trainings.CSharp.Selenium.Demobank.Pages;
using Testerzy.Trainings.CSharp.Selenium.Framework;
using Testerzy.Trainings.CSharp.Selenium.Framework.BusinessModels;
using Testerzy.Trainings.CSharp.Selenium.Framework.BusinessModels.Errors;
using Testerzy.Trainings.CSharp.Selenium.Framework.Extensions;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests.Configuration;

public class ConfigurationTests
{
    [Test]
    public void TestConfigurationConstants()
    {
        string actualAccountName = "rachunki oszczędnościowe";

        Assert.That(actualAccountName, Is.EqualTo(Constants.Demobank.MyDesktopTab.SavingsAccountName));
    }

    [Test]
    public void TestConfigurationEnums()
    {
        var registerPage = new ExampleConfigPage();
        registerPage.SelectAccountType(AccountType.Personal);
    }

    [Test]
    public void TestConfigurationEnumsDescriptionValue()
    {
        string value1002 = UserError.UserAlreadyExists.GetDescription();

        Assert.That(value1002, Is.EqualTo("User already exists"));

        string value = AccountType.Personal.GetDescription();
        Assert.That(value, Is.EqualTo(AccountType.Personal.ToString()));
    }

    [Test]
    public void TestConfigurationDictionary()
    {
        string errorMessage = ErrorDictionary.UserErrors[1012];

        Assert.That(errorMessage, Is.EqualTo("Invalid user provided"));
    }

    [Test]
    public void TestConfigurationClass()
    {
        var error = ReportError.InvalidUserProvided;
        int errorCode = error.Code;
        string errorMessage = error.Message;

        Assert.That(errorCode, Is.EqualTo(1012));
        Assert.That(errorMessage, Is.EqualTo("Invalid user provided"));

        Assert.That(ReportError.NotSupportedValue.Code, Is.EqualTo(1024));
    }

    [Test]
    public void TestConfigurationAppSettings()
    {
        Settings settings = new SettingsBuilder()
            .AddAppSettings()
            .Build();

        Assert.That(settings.App.Url, Is.EqualTo("https://demo-bank.vercel.app/"));
        Assert.That(settings.TestData.Users.Count, Is.EqualTo(2));
        Assert.That(settings.TestData.Users.First().Username, Is.EqualTo("OkUser01"));
    }

    [Test]
    public void TestGlobalConfigurationAppSettings()
    {
        Assert.That(GlobalSetup.Settings.App.Url, Is.EqualTo("https://demo-bank.vercel.app/"));
        Assert.That(GlobalSetup.Settings.TestData.Users.Count, Is.EqualTo(2));
        Assert.That(GlobalSetup.Settings.TestData.Users.First().Username, Is.EqualTo("OkUser01"));
    }
}
