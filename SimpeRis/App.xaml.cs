using Prism.Ioc;
using Prism.Modularity;
using SimpeRis.Views;
using SimpeRis.WorkList;
using System.Windows;

namespace SimpeRis
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterSingleton<Lib.Setting.Setting>();

        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<WorkListModule>(InitializationMode.WhenAvailable);
        }

    }
}
