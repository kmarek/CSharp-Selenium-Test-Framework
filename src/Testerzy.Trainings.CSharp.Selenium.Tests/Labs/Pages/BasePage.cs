﻿using OpenQA.Selenium;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Labs.Pages;

public class BasePage
{
    protected IWebDriver Driver { get; init; }

    public BasePage(IWebDriver driver)
    {
        Driver = driver;
    }
}