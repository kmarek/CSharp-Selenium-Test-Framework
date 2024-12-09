using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests.Presentation;

public class CreateBrowsersTests
{
    [Test]
    public void CreateChrome()
    {
        var options = new ChromeOptions();
        options.AddArgument("--headless");
        options.AddArgument("--start-maximized");
        IWebDriver driverWithOptions = new ChromeDriver(options);
        driverWithOptions.Quit();
    }

    [Test]
    public void CreateFirefox()
    {
        var options = new FirefoxOptions();
        options.AddArgument("-headless");
        IWebDriver driverWithOptions = new FirefoxDriver(options);
        driverWithOptions.Quit();
    }

    [Test]
    public void CreateEdge()
    {
        var options = new EdgeOptions();
        options.AddArgument("--start-maximized");
        options.AddArgument("--headless");
        IWebDriver driverWithOptions = new EdgeDriver(options);
        driverWithOptions.Quit();
    }
}
