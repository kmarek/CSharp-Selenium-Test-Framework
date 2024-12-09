using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using Testerzy.Trainings.CSharp.Selenium.Configuration.Models;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank;

public class WebDriverFactory
{
    public static IWebDriver Create(BrowserName browserName)
    {
        switch (browserName)
        {
            case BrowserName.Chrome:
                return new ChromeDriver();
            case BrowserName.Firefox:
                return new FirefoxDriver();
            case BrowserName.Edge:
                return new EdgeDriver();
            default:
                throw new NotSupportedException($"{browserName} is not supported!");
        }
    }
}
