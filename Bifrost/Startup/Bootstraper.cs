using Autofac;
using Bifrost.Common;
using Bifrost.DL;
using Bifrost.UI.ViewModel;

namespace Bifrost.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<ConfigurationService>().As<IConfigurationService>();

            return builder.Build();
        }
    }
}
