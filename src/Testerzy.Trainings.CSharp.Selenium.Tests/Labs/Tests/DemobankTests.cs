using Testerzy.Trainings.CSharp.Selenium.Demobank.Labs.Pages;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Labs.Tests;

public class DemobankTests : BaseTest
{
    [Test]
    public void Verify_SuccesfullQuickPayment()
    {
        var loginPage = OpenDemobankLoginPage();
        var myDesktopPage = loginPage.LoginSuccessfully("username", "password");
        myDesktopPage.QuickPayment.SendPayment("Jan Demobankowy", 123, "title");

        var dialog = myDesktopPage.GetDialog();

        Assert.That(dialog.GetTitle(), Is.EqualTo("Przelew wykonany"));

        dialog.Close();
    }

    [Test]
    public void Test()
    {
        var loginPage = new LoginPage(WebDriver);
        loginPage.SetUserName("kamil.marek@gmail.com");
        loginPage.SetPassword("password");

        var dashboardPage = new DashboardPage(WebDriver);
        string title = dashboardPage.GetTitle();

        Assert.That(title, Is.EqualTo("Main Page"));
    }
}
