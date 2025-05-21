using OpenQA.Selenium;
using Testerzy.Trainings.CSharp.Selenium.Demobank.Labs.Components;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Labs.Pages;

public class DashboardPage : BasePage
{
    protected By UiDialogLocator => By.CssSelector(".ui-dialog");

    public DashboardPage(IWebDriver driver) : base(driver)
    {
    }

    public UiDialogComponent GetDialog()
    {
        var uiDialogElement = Driver.FindElement(UiDialogLocator);
        return new UiDialogComponent(uiDialogElement);
    }

    public string GetTitle() => "";
}
