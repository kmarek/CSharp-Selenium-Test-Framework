using OpenQA.Selenium;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests;

public class TakeScreenshotTests : BaseTest
{
    [Test]
    public void TakeScreenshot()
    {

        Screenshot screenshot = (WebDriver as ITakesScreenshot)!.GetScreenshot();
        screenshot.SaveAsFile("screenshot.png");

        Screenshot screenshot1 = ((ITakesScreenshot)WebDriver).GetScreenshot();
        screenshot.SaveAsFile("screenshot1.png");
    }
}
