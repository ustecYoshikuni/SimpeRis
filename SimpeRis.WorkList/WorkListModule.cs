using SimpeRis.WorkList.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace SimpeRis.WorkList
{
    public class WorkListModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManeger = containerProvider.Resolve<IRegionManager>();
            regionManeger.RegisterViewWithRegion("ContentRegion", typeof(Views.WorkList));

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Views.WorkList>();
        }
    }
}