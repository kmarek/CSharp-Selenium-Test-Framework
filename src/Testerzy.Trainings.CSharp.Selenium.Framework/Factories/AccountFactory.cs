using Testerzy.Trainings.CSharp.Selenium.Framework.BusinessModels;

namespace Testerzy.Trainings.CSharp.Selenium.Framework.Factories;

public class AccountFactory
{
    public static Account CreateAdmin()
    {
        Account adminUser = new()
        {
            Username = "Johnny the Admin",
            FirstName = "John",
            LastName = "Doe",
            BankAccount = new()
            {
                AccountNumber = "PL 1234 4321 1234"
            },
            Permissions = new()
            {
                new Permission("Admin", "ADM", "ALL"),
                new Permission("Accounts-Read", "ACCREAD", "INTERNAL")
            }
        };
        return adminUser;
    }
}
