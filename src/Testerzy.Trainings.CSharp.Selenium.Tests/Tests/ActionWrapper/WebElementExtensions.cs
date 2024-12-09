using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests.ActionWrapper;

public static class WebElementExtensions
{
    public static IWebDriver GetWebDriver(this IWebElement webElement)
    {
        return ((IWrapsDriver)webElement).WrappedDriver;
    }

    public static void ScrollToIt(this IWebElement webElement)
    {
        Actions actions = new(webElement.GetWebDriver());
        actions.MoveToElement(webElement);
        actions.Perform();
    }

    public static string GetValue(this IWebElement webElement)
    {
        return webElement.GetDomAttribute("value");
    }

    public static void RemoveReadonlyAttribute(this IWebElement webElement)
    {
        IWebDriver webDriver = webElement.GetWebDriver();
        ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].removeAttribute('readonly',0);", webElement);
    }
}
