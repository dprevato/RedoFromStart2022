using Core.Mvvm;

namespace RedoFromStart.ViewModels
{
    public class ShellViewModel : RegionViewModelBase
    {
        public ShellViewModel() {
            Title = "REDO FROM START - © 2022 Daniele Prevato";
            ShowTitleBar = true;
            ShowIconOnTitleBar = true;
        }

        #region ShowTitleBar

        private bool myShowTitleBar;

        public bool ShowTitleBar {
            get => myShowTitleBar;
            set => SetProperty(ref myShowTitleBar, value);
        }

        #endregion ShowTitleBar

        #region ShowIconOnTitleBar

        private bool myShowIconOnTitleBar;

        public bool ShowIconOnTitleBar {
            get => myShowIconOnTitleBar;
            set => SetProperty(ref myShowIconOnTitleBar, value);
        }

        #endregion ShowIconOnTitleBar
    }
}
