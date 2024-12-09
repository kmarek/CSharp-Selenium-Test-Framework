using Serilog;
using System.Reflection;
using Testerzy.Trainings.CSharp.Selenium.Configuration;
using Testerzy.Trainings.CSharp.Selenium.Configuration.Models;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank;

[SetUpFixture]
public class GlobalSetup
{
    private const string _outputTemplate = "[{Timestamp:dd-MMM-yyyy HH:mm:ss.fff} {Level:u3}] {Message}{NewLine}";
    public static Settings Settings { get; private set; }

    [OneTimeSetUp]
    public void GlobalOneTimeSetup()
    {
        Settings = new SettingsBuilder()
            .AddAppSettings()
            .Build();

        string logPath = Path.Combine(TestContext.CurrentContext.TestDirectory,
            $"{Assembly.GetExecutingAssembly().GetName()?.Name}.log");

        ILogger logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.File(logPath, rollingInterval: RollingInterval.Hour, outputTemplate: _outputTemplate)
                .WriteTo.Console(outputTemplate: _outputTemplate)
                .CreateLogger();

        Log.Information("GlobalOneTimeSetup message");
    }
}