using OpenQA.Selenium;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Labs.Components;

public class UiDialogComponent : BaseComponent
{
    protected By TitleLocator => By.CssSelector(".ui-dialog-titlebar");
    protected By CloseBtnLocator => By.CssSelector("[data-testid='close-button']");

    public UiDialogComponent(IWebElement baseElement) : base(baseElement)
    {
    }

    public string GetTitle()
    {
        return BaseElement.FindElement(TitleLocator).Text;
    }

    public void Close()
    {
        BaseElement.FindElement(CloseBtnLocator).Click();
    }
}
