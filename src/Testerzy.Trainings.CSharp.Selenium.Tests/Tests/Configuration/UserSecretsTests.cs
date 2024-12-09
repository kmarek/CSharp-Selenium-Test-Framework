using Testerzy.Trainings.CSharp.Selenium.Configuration;
using Testerzy.Trainings.CSharp.Selenium.Configuration.Models;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests.Configuration;

public class UserSecretsTests
{
    [Test]
    public void VerifyApiKeyIsLoadedFromUserSecrets()
    {
        Settings settings = new SettingsBuilder()
            .AddAppSettings()
            .AddUserSecrets()
            .Build();

        Assert.That(settings.App.Url, Is.EqualTo("https://demo-bank.vercel.app/"));
        Assert.That(settings.App.ApiKey, Is.EqualTo("abc123cde321"));
    }
}
