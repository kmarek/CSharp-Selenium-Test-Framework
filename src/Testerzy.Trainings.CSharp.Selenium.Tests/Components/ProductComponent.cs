using OpenQA.Selenium;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Components;

public class ProductComponent(IWebElement baseElement) : BaseComponent(baseElement)
{
    protected By AddToCartBtnLocator => By.CssSelector(".btn_inventory");
    protected By NameLocator => By.CssSelector(".inventory_item_name");
    protected By PriceLocator => By.CssSelector(".inventory_item_price");

    public string GetName()
    {
        return BaseElement.FindElement(NameLocator).Text;
    }

    public void AddToCart()
    {
        BaseElement.FindElement(AddToCartBtnLocator).Click();
    }
}
