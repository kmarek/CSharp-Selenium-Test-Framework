using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Testerzy.Trainings.CSharp.Selenium.Demobank.Extensions;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests;

public class WaitExamplesTests : BaseTest
{
    [Test]
    public void ImplicitWait()
    {
        WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
    }

    [Test]
    public void Test1a()
    {
        var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10))
        {
            PollingInterval = TimeSpan.FromSeconds(1)
        };
        wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));

        wait.Until(webDriver => webDriver.FindElement(By.Id("id")).Enabled);
    }

    [Test]
    public void Test1()
    {
        var webDriverWait = WebDriver.GetWait(TimeSpan.FromSeconds(10));
        IWebElement webElement = WebDriver.FindElement(By.Id("id"));
        bool isEnabled = webDriverWait.Until(driver => webElement.Enabled);

        webDriverWait.Until(d =>
        {
            webElement.SendKeys("Displayed");
            return true;
        });
    }

    [Test]
    public void Test2()
    {
        DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(WebDriver);
    }


}
