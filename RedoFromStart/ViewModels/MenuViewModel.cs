using Core.Mvvm;
using Core.Services;
using Prism.Commands;
using Prism.Events;

namespace RedoFromStart.ViewModels;

public class MenuViewModel : ViewModelBase
{
    private readonly IEventAggregator _eventAggregator;
    private readonly IUserService _user;

    public MenuViewModel(IEventAggregator eventAggregator, IUserService user) {
        _eventAggregator = eventAggregator;
        _user = user;

        // inizializzazione
        UserAdmin = _user.Admin();
        Unlocked = false;
        NotForGuest = _user.User();
        UserPowerUser = _user.PowerUser();
    }

    #region Properties

    #region UserAdmin

    private bool _userAdmin;

    public bool UserAdmin
    {
        get => _userAdmin;
        set => SetProperty(ref _userAdmin, value);
    }

    #endregion UserAdmin

    #region Unlocked

    private bool _unlocked;

    public bool Unlocked
    {
        get => _unlocked;
        set => SetProperty(ref _unlocked, value);
    }

    #endregion Unlocked

    #region NotForGuest

    private bool _notForGuest;

    public bool NotForGuest
    {
        get => _notForGuest;
        set => SetProperty(ref _notForGuest, value);
    }

    #endregion NotForGuest

    #region UserPowerUser

    private bool _userPowerUser;

    public bool UserPowerUser
    {
        get => _userPowerUser;
        set => SetProperty(ref _userPowerUser, value);
    }

    #endregion UserPowerUser

    #endregion Properties


    #region Commands

    #region NavigateCommand

    private DelegateCommand<string> _fieldNavigate = null!;
    public DelegateCommand<string> NavigateCommand => _fieldNavigate ??= new DelegateCommand<string>(Navigate, CanNavigate);

    private bool CanNavigate(string path) => true;

    private void Navigate(string path) {
        if (path == null) return;

        // TODO: Devo caricare il modulo che contiene la vista
    }

    #endregion NavigateCommand

    #region CloseAppCommand
    private DelegateCommand _fieldCloseApp;
    public DelegateCommand CloseAppCommand => _fieldCloseApp ??= new DelegateCommand(CloseApp, CanCloseApp); 

    private void CloseApp()
    {
    }

    private bool CanCloseApp() => true; 

    #endregion CloseAppCommand


    #endregion Commands
}