using Core;
using Prism.Ioc;
using Prism.Regions;

namespace RedoFromStart.Views;

/// <summary>
///     Interaction logic for Shell.xaml
/// </summary>
public partial class Shell
{
    private readonly IContainerExtension _container;
    private readonly IRegionManager _regionManager;
    private IRegion _topRegion;

    private MenuView _menuView;

    public Shell(){}

    public Shell(IContainerExtension container, IRegionManager regionManager) {
        InitializeComponent();
        _container = container;
        _regionManager = regionManager;

        this.Loaded += Shell_Loaded;
    }

    private void Shell_Loaded(object sender, System.Windows.RoutedEventArgs e) {
        _menuView = _container.Resolve<MenuView>();

        _topRegion = _regionManager.Regions[KnownRegionNames.TopRegion];

        _topRegion.Add(_menuView);
        _topRegion.Activate(_menuView);
    }
}