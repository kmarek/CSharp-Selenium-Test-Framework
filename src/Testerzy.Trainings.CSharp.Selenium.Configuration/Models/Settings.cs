namespace Testerzy.Trainings.CSharp.Selenium.Configuration.Models;

public class Settings
{
    public App App { get; set; } = new();
    public Database Database { get; set; } = new();
    public TestData TestData { get; set; } = new();
    public BrowserName BrowserName { get; set; }
}
