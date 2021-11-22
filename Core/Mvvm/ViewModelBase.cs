using Prism.Mvvm;
using Prism.Navigation;

namespace Core.Mvvm
{
    public abstract class ViewModelBase : BindableBase, IDestructible
    {

        public ViewModelBase()
        {

        }
        #region Implementation of IDestructible

        public virtual void Destroy() { }

        #endregion Implementation of IDestructible
    }
}