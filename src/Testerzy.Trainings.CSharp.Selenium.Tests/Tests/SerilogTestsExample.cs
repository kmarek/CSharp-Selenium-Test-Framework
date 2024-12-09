using Serilog;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests;

[Parallelizable(ParallelScope.Self)]
public class SerilogTestsExample
{
    [Test]
    public void TestLogger()
    {
        Log.Debug("TestLogger debug message");
        Log.Information("TestLogger info message");
        Log.Warning("TestLogger warning message");
        Log.Error("TestLogger error message");
    }
}
