using Bifrost.Model;
using System.Collections.Generic;

namespace Bifrost.DL
{
    public interface IConfigurationService
    {
        IEnumerable<BaseConfiguration> GetAll();
    }
}