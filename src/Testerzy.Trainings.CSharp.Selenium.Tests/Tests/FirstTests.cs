using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests;

[Parallelizable(ParallelScope.Self)]
public class FirstTests
{
    [Test]
    public void Test1()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://kamilmarek.pl");
        driver.Quit();
    }

    [Test]
    public void Test2()
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");

        var title = driver.Title;

        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

        var textBox = driver.FindElement(By.Name("my-text"));
        var submitButton = driver.FindElement(By.TagName("button"));

        textBox.SendKeys("Selenium");
        submitButton.Click();

        var message = driver.FindElement(By.Id("message"));
        var value = message.Text;

        driver.Quit();
    }
}
