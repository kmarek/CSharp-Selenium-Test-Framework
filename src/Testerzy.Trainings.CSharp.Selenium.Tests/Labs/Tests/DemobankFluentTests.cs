using FluentAssertions;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Labs.Tests;

public class DemobankFluentTests : BaseTest
{
    [Test]
    public void Verify_SuccesfullQuickPayment()
    {
        int paymentAmount = 123;

        var myDesktopPage = OpenDemobankLoginPage()
            .LoginSuccessfully("username", "password");

        int initialBalance = myDesktopPage.GetBalance();

        int finalBalance = myDesktopPage
            .SendQuickPayment("Jan Demobankowy", paymentAmount, "title")
            .GetBalance();

        Assert.That(initialBalance - finalBalance, Is.EqualTo(paymentAmount));
    }

    [Test]
    public void Verify_SuccesfullQuickPayment_Out()
    {
        int paymentAmount = 123;

        OpenDemobankLoginPage()
            .LoginSuccessfully("username", "password")
            .GetBalance(out int initialBalance)
            .SendQuickPayment("Jan Demobankowy", paymentAmount, "title")
            .GetBalance(out int finalBalance);

        Assert.That(initialBalance - finalBalance, Is.EqualTo(paymentAmount));
    }

    [Test]
    public void Verify_SuccesfullQuickPayment_FluentAssertions()
    {
        int paymentAmount = 123;

        OpenDemobankLoginPage()
            .LoginSuccessfully("username", "password")
            .GetBalance(out int initialBalance)
            .SendQuickPayment("Jan Demobankowy", paymentAmount, "title")
            .GetBalance()
            .Should()
            .Be(initialBalance - paymentAmount);
    }
}
