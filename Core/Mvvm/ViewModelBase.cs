using Prism.Mvvm;
using Prism.Navigation;

namespace Core.Mvvm
{
    public abstract class ViewModelBase : BindableBase, IDestructible
    {
        #region Title

        private string _title = "Title Check";

        public string Title {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        #endregion Title

        #region Implementation of IDestructible

        public virtual void Destroy() { }

        #endregion Implementation of IDestructible
    }
}