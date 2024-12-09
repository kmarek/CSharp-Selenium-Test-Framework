using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Selenium;

[Parallelizable(ParallelScope.Self)]
public class ChromeTests
{
    [Test]
    public void RunChromeDriver()
    {
        IWebDriver chrome = new ChromeDriver();

        //By id = By.Id("id");
        By loginBtnLocator = ByExt.DataTestId("login-btn");

        //IWebElement element = chrome.FindElement(id);

        chrome.Quit();
    }
}
