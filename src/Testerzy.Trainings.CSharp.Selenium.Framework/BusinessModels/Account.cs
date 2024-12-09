namespace Testerzy.Trainings.CSharp.Selenium.Framework.BusinessModels;

public class Account
{
    public string Username { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public BankAccount BankAccount { get; set; } = new();
    public List<Permission> Permissions { get; set; } = [];

}
