using Bifrost.Model;
using System;
using System.Collections.Generic;

namespace Bifrost.DL
{
    public class ConfigurationService : IConfigurationService
    {
        public IEnumerable<BaseConfiguration> GetAll()
        {
            yield return new LogoutConfiguration { ActivationKey = "Q", IsEnabled = true };
        }
    }
}
