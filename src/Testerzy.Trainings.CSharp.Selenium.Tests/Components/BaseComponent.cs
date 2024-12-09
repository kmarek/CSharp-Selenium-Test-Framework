using OpenQA.Selenium;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Components;

public class BaseComponent
{
    protected IWebElement BaseElement { get; init; }

    public BaseComponent(IWebElement baseElement)
    {
        BaseElement = baseElement;
    }
}
