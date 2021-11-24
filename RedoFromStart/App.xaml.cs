using Prism.DryIoc;
using Prism.Ioc;
using RedoFromStart.ViewModels;
using RedoFromStart.Views;
using System.Windows;
using Core.Services;
using Services;
using Services.Interfaces;

namespace RedoFromStart
{
    public partial class App : PrismApplication
    {
        #region Overrides of PrismApplicationBase

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<Shell>();
            containerRegistry.Register<ShellViewModel>();
            containerRegistry.RegisterSingleton<IIconService, IconService>();
            containerRegistry.RegisterSingleton<IUserService, UserService>();

        }
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        #endregion
    }
}
