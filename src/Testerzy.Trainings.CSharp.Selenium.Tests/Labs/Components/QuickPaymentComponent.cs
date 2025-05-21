using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Testerzy.Trainings.CSharp.Selenium.Demobank.Extensions;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Labs.Components;

public class QuickPaymentComponent : BaseComponent
{
    protected By ReceiverLocator => By.Id("widget_1_transfer_receiver");
    protected By AmountLocator => By.Id("widget_1_transfer_amount");
    protected By TitleLocator => By.Id("widget_1_transfer_title");
    protected By ExecuteBtnLocator => By.Id("execute_btn");

    public QuickPaymentComponent(IWebElement baseElement) : base(baseElement)
    {
    }

    public void SendPayment(string receiver, int amount, string title)
    {
        var selectElement = BaseElement.FindElement(ReceiverLocator);
        var select = new SelectElement(selectElement);
        select.SelectByText(receiver);

        BaseElement.GetSelect(ReceiverLocator).SelectByText(receiver);

        BaseElement.FindElement(AmountLocator).SendKeys(amount.ToString());
        BaseElement.FindElement(TitleLocator).SendKeys(title);
        BaseElement.FindElement(ExecuteBtnLocator).Click();
    }
}
