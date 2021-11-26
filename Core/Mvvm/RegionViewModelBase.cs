using System;
using Prism.Regions;

namespace Core
{
    public class RegionViewModelBase : ViewModelBase, IConfirmNavigationRequest
    {
        protected IRegionManager RegionManager { get; set; }

        public RegionViewModelBase(IRegionManager regionManager)
        {
            RegionManager = regionManager;
        }

        public RegionViewModelBase() { }

        #region Implementation of INavigationAware

        public virtual void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            continuationCallback.Invoke(true);
        }

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext) { }

        public virtual void OnNavigatedTo(NavigationContext navigationContext) { }

        #endregion Implementation of INavigationAware
    }
}