using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Extensions;

public static class WebElementExtensions
{
    public static bool IsActive(this IWebElement webElement)
    {
        return webElement.GetDomAttribute("class").Contains("active");
    }

    public static bool ContainsClass(this IWebElement webElement, string className)
    {
        return webElement.GetDomAttribute("class").Contains(className);
    }

    public static IWebElement WaitUntilClickable(this IWebElement webElement)
    {
        var webDriver = ((IWrapsDriver)webElement).WrappedDriver;
        return webDriver.GetWait(TimeSpan.FromSeconds(10))
            .Until(ExpectedConditions.ElementToBeClickable(webElement));
    }

    public static SelectElement GetSelect(this IWebElement webElement, By selectLocator)
    {
        var selectElement = webElement.FindElement(selectLocator);
        return new SelectElement(selectElement);
    }
}
