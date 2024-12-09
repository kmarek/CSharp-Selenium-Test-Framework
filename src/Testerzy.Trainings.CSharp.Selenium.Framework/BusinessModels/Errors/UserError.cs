using System.ComponentModel;

namespace Testerzy.Trainings.CSharp.Selenium.Framework.BusinessModels.Errors;

public enum UserError
{
    [Description("User already exists")]
    UserAlreadyExists = 1002,
    [Description("Invalid user provided")]
    InvalidUserProvided = 1012,
    [Description("Not supported value")]
    NotSupportedValue = 1024
}
