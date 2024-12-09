using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testerzy.Trainings.CSharp.Selenium.Demobank.Tests.Demobank;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests.Presentation;

public class UploadFileTests : BaseTest
{
    private DemobankCommonActions _actions;

    [SetUp]
    public void SetUp()
    {
        _actions = new(WebDriver);
    }

    [Test]
    public void TestUploadFile()
    {
        OpenDemobankLoginPage();
        _actions.Login("username", "password");

        WebDriver.FindElement(By.Id("reports_btn")).Click();

        string pathToFile = "C:\\dev\\testfile.txt";
        By fileInputLocator = By.Id("my_file_1");
        WebDriver.FindElement(fileInputLocator).SendKeys(pathToFile);

        string filename = WebDriver.FindElement(By.CssSelector(".filename")).Text;
        Assert.That(filename, Is.EqualTo("testfile.txt"));
    }
}
