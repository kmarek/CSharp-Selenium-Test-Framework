namespace Testerzy.Trainings.CSharp.Selenium.Framework.BusinessModels;

public class Permission
{
    public string Name { get; private set; }
    public string Code { get; private set; }
    public string Scope { get; private set; }

    public Permission(string name, string code, string scope)
    {
        Name = name;
        Code = code;
        Scope = scope;
    }
}
