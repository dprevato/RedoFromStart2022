using Blank.Views;
using Core.Mvvm;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Blank
{
    public class BlankModule : IModule
    {
        #region Implementation of IModule

        public void RegisterTypes(IContainerRegistry containerRegistry) { }

        public void OnInitialized(IContainerProvider containerProvider) {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            IRegion region = regionManager.Regions[KnownRegionNames.ContentRegion];

            var v = containerProvider.Resolve<BlankView>();
            region.Add(v);

            // Le due righe di codice sopra devono essere ripetute per tutte le viste presenti nel modulo

        }

        #endregion

    }
}
