using FluentAssertions;
using OpenQA.Selenium;
using Testerzy.Trainings.CSharp.Selenium.Demobank.Selenium;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests.ActionWrapper;

public class ByExtTests : BaseTest
{
    [Test]
    public void TestByExtMethods()
    {
        OpenDemobankLoginPage();
        IWebElement login = WebDriver.FindElement(ByExt.Type("submit"));
        login.Click();

        var error = WebDriver.FindElement(ByExt.DataTestId("error-login-id"));
        error.Text.Should().Be("pole wymagane");
    }
}
