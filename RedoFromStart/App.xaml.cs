using Prism.DryIoc;
using Prism.Ioc;
using RedoFromStart.ViewModels;
using RedoFromStart.Views;
using System.Windows;

namespace RedoFromStart
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        #region Overrides of PrismApplicationBase

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<Shell>();
            containerRegistry.Register<ShellViewModel>();
        }
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        #endregion
    }
}
