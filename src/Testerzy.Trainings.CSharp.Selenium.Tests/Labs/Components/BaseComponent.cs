using OpenQA.Selenium;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Labs.Components;

public class BaseComponent
{
    protected IWebElement BaseElement { get; init; }
    public BaseComponent(IWebElement baseElement)
    {
        BaseElement = baseElement;
    }
}
