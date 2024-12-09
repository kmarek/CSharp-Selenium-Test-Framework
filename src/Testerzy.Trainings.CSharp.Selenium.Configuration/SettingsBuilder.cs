using Microsoft.Extensions.Configuration;
using Testerzy.Trainings.CSharp.Selenium.Configuration.Models;

namespace Testerzy.Trainings.CSharp.Selenium.Configuration;

public class SettingsBuilder
{
    private readonly Settings _settings;
    private readonly ConfigurationBuilder _builder;

    public SettingsBuilder()
    {
        _settings = new();
        _builder = new ConfigurationBuilder();
    }

    public SettingsBuilder AddAppSettings()
    {
        string envVarName = "E2E-ENVIRONMENT";
        string environment = Environment.GetEnvironmentVariable(envVarName, EnvironmentVariableTarget.User)
            ?? Environment.GetEnvironmentVariable(envVarName)
            ?? "not-set";

        _builder
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile($"appSettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appSettings{environment}.json", optional: true, reloadOnChange: true);

        return this;
    }

    public SettingsBuilder AddBaseAppSettings()
    {
        _builder
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile($"appSettings.json", optional: false, reloadOnChange: true);

        return this;
    }

    public SettingsBuilder AddUserSecrets()
    {
        _builder.AddUserSecrets<Settings>();

        return this;
    }

    public Settings Build()
    {
        IConfigurationRoot configuration = _builder.Build();
        configuration.Bind(_settings);
        return _settings;
    }
}
