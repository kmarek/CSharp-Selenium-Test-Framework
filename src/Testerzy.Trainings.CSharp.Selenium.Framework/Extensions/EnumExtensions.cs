using System.ComponentModel;
using System.Reflection;
using Testerzy.Trainings.CSharp.Selenium.Framework.BusinessModels.Errors;

namespace Testerzy.Trainings.CSharp.Selenium.Framework.Extensions;

public static class EnumExtensions
{
    public static string GetDescription(this UserError source)
    {
        FieldInfo? fi = source.GetType().GetField(source.ToString() ?? string.Empty);

        if (fi == null) return string.Empty;

        var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

        return attributes.Length > 0 ? attributes[0].Description : source.ToString() ?? string.Empty;
    }

    public static string GetDescription<T>(this T source) where T : Enum
    {
        if (source == null) return string.Empty;

        FieldInfo? fi = source.GetType().GetField(source.ToString() ?? string.Empty);

        if (fi == null) return string.Empty;

        var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

        return attributes.Length > 0 ? attributes[0].Description : source.ToString() ?? string.Empty;
    }
}
