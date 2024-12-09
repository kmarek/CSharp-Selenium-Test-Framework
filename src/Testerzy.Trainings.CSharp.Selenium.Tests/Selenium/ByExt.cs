using OpenQA.Selenium;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Selenium;

public static class ByExt
{
    public static By DataTestId(string dataTestId)
    {
        return By.CssSelector($"[data-testid={dataTestId}]");
    }

    public static By Role(string role)
    {
        return By.CssSelector($"[role='{role}']");
    }

    public static By Type(string type)
    {
        return By.CssSelector($"[type='{type}']");
    }
}
