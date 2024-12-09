using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testerzy.Trainings.CSharp.Selenium.Demobank;

namespace Testerzy.Trainings.CSharp.Selenium.Demobank.Tests.Logging;

public class LoggerPerTestExampleTests : BaseSauceDemoTestWithLogger
{
    [Test]
    public void TestLogger()
    {
        Logger.Information("Log entry for test.");
    }
}
