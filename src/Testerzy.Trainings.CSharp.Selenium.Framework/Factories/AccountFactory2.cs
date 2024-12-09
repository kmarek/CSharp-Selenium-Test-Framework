using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testerzy.Trainings.CSharp.Selenium.Framework.BusinessModels;

namespace Testerzy.Trainings.CSharp.Selenium.Framework.Factories;

public class AccountFactory2
{
    private EnvSettings _settings;

    public AccountFactory2(EnvSettings settings)
    {
        _settings = settings;
    }

    public Account CreateAdmin()
    {
        return new Account()
        {
            Username = $"{_settings.Prefix} Admin"
        };
    }
}
