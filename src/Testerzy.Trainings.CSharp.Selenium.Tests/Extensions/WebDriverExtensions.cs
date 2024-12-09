using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Extensions;

public static class WebDriverExtensions
{
    public static WebDriverWait GetWait(this IWebDriver webDriver, TimeSpan timeout)
    {
        return webDriver.GetWait(timeout, TimeSpan.FromSeconds(1));
    }

    public static WebDriverWait GetWait(this IWebDriver webDriver, TimeSpan timeout, TimeSpan interval)
    {
        var wait = new WebDriverWait(webDriver, timeout)
        {
            PollingInterval = interval
        };
        wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));

        return wait;
    }
}
