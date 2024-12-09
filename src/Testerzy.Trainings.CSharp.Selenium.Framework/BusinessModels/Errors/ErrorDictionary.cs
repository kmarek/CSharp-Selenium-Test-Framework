namespace Testerzy.Trainings.CSharp.Selenium.Framework.BusinessModels.Errors;

public static class ErrorDictionary
{
    public static Dictionary<int, string> UserErrors => new()
    {
        { 1012, "Invalid user provided" },
        { 1024, "Not supported value" }
    };
}
