﻿using OpenQA.Selenium;
using Testerzy.Trainings.CSharp.Selenium.Demobank.Components;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Pages.SauceDemo;

public class ProductsPage(IWebDriver driver) : BasePage(driver)
{
    protected By InventoryItemLocator => By.CssSelector(".inventory_item");
    protected By AddToCartBtnLocator => By.CssSelector(".btn_inventory");
    protected By CartProductCount => By.CssSelector(".shopping_cart_badge");
    protected By CartLinkLocator => By.CssSelector(".shopping_cart_link");

    public List<ProductComponent> Products => GetProducts();

    public ProductsPage AddItemToCart(int index)
    {
        Products[index].AddToCart();
        return this;
    }

    public CartPage OpenCart()
    {
        Driver.FindElement(CartLinkLocator).Click();
        return new CartPage(Driver);
    }

    public List<ProductComponent> GetProducts()
    {
        var products = Driver.FindElements(InventoryItemLocator)
            .Select(webElement => new ProductComponent(webElement))
            .ToList();

        Console.WriteLine($"Returning {products.Count} products.");
        //products.ForEach(product => Console.WriteLine($"Product '{product.GetName()}'"));
        return products;
    }

    public ProductComponent GetProduct(string productName)
    {
        Console.WriteLine($"Trying to get product '{productName}'.");
        return GetProducts()
            .First(productComponent => productComponent.GetName() == productName);
    }

    public int GetProductInCartCount()
    {
        string count = Driver.FindElement(CartProductCount).Text;
        return Convert.ToInt32(count);
    }
}
