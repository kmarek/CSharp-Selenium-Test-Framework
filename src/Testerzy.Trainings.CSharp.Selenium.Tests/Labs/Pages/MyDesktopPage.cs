using OpenQA.Selenium;
using Testerzy.Trainings.CSharp.Selenium.Demobank.Labs.Components;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Labs.Pages;

public class MyDesktopPage : DashboardPage
{
    protected By AccountBalance => By.Id("money_value");
    public QuickPaymentComponent QuickPayment => new(Driver.FindElements(By.CssSelector(".accounts-widgets .widget"))[0]);

    public MyDesktopPage(IWebDriver driver) : base(driver)
    {
    }

    public MyDesktopPage SendQuickPayment(string receiver, int amount, string title)
    {
        QuickPayment.SendPayment(receiver, amount, title);
        GetDialog().Close();
        return this;
    }
}
