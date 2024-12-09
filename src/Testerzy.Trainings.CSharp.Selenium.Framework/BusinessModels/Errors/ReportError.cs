namespace Testerzy.Trainings.CSharp.Selenium.Framework.BusinessModels.Errors;

public class ReportError
{
    public int Code { get; }
    public string Message { get; }

    public ReportError(int code, string message)
    {
        Code = code;
        Message = message;
    }

    public static ReportError InvalidUserProvided => new(1012, "Invalid user provided");
    public static ReportError NotSupportedValue => new(1024, "Not supported value");
}
