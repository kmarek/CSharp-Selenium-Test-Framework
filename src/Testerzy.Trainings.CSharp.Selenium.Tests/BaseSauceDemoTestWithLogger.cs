using Serilog;
using ILogger = Serilog.ILogger;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank;

public class BaseSauceDemoTestWithLogger : BaseSauceDemoTest, IDisposable
{
    public ILogger Logger { get; private set; }

    [SetUp]
    public void BaseLoggerSetUp()
    {
        string logPath = Path.Combine(TestContext.CurrentContext.TestDirectory,
            $"{TestContext.CurrentContext.Test.Name}.log");

        Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.File(logPath)
                .WriteTo.Console()
                .CreateLogger();

        Logger.Information($"Saving logs to {logPath}");
    }

    public void Dispose() { ((IDisposable)Logger).Dispose(); }
}
