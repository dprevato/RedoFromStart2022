using Core;
using Core.Events;
using Core.Services;
using DataAccess;
using Prism.Commands;
using Prism.Events;

namespace RedoFromStart.ViewModels;

public class MenuViewModel : ViewModelBase
{
    private readonly IEventAggregator _eventAggregator;
    private readonly IUserService _user;

    public MenuViewModel(IEventAggregator eventAggregator, IUserService user, MenuViewLookups mvLookups) {
        MvLookups = mvLookups;
        _eventAggregator = eventAggregator;
        _user = user;

        // inizializzazione
        UserAdmin = _user.Admin();
        Unlocked = false;
        NotForGuest = _user.User();
        UserPowerUser = _user.PowerUser();
    }

    public MenuViewLookups MvLookups { get; }

    #region Properties

    #region UserAdmin

    private bool _userAdmin;

    public bool UserAdmin {
        get => _userAdmin;
        set => SetProperty(ref _userAdmin, value);
    }

    #endregion UserAdmin

    #region RootCode

    private string _rootCode;

    public string RootCode {
        get => _rootCode;
        set => SetProperty(ref _rootCode, value);
    }

    #endregion RootCode

    #region Unlocked

    private bool _unlocked;

    public bool Unlocked {
        get => _unlocked;
        set => SetProperty(ref _unlocked, value);
    }

    #endregion Unlocked

    #region NotForGuest

    private bool _notForGuest;

    public bool NotForGuest {
        get => _notForGuest;
        set => SetProperty(ref _notForGuest, value);
    }

    #endregion NotForGuest

    #region UserPowerUser

    private bool _userPowerUser;

    public bool UserPowerUser {
        get => _userPowerUser;
        set => SetProperty(ref _userPowerUser, value);
    }

    #endregion UserPowerUser

    #region PlantSelected

    private bool _plantSelected;

    public bool PlantSelected {
        get => _plantSelected;
        set => SetProperty(ref _plantSelected, value);
    }

    #endregion PlantSelected

    #region SelectedPlant

    private string _selectedPlant;

    public string SelectedPlant {
        get => _selectedPlant;
        set => SetProperty(ref _selectedPlant, value, OnPlantSelected);
    }

    private void OnPlantSelected() {
        PlantSelected = true;
        UpdateRootCode();
    }

    #endregion SelectedPlant

    #region KindSelected

    private bool _kindSelected;

    public bool KindSelected {
        get => _kindSelected;
        set => SetProperty(ref _kindSelected, value);
    }

    #endregion KindSelected

    #region SelectedKind

    private string _selectedKind;

    public string SelectedKind {
        get => _selectedKind;
        set => SetProperty(ref _selectedKind, value);
    }

    #endregion SelectedKind

    #region SelectedSubKind

    private string _selectedSubKind;

    public string SelectedSubKind {
        get => _selectedSubKind;
        set => SetProperty(ref _selectedSubKind, value);
    }

    #endregion SelectedSubKind

    #endregion Properties

    #region Commands

    private void UpdateRootCode() {
        RootCode = $"{PlantSelected}{SelectedKind}{SelectedSubKind}";
        _eventAggregator.GetEvent<RootCodeEvent>().Publish(RootCode);
    }

    #region NavigateCommand

    private DelegateCommand<string> _fieldNavigate = null!;
    public DelegateCommand<string> NavigateCommand => _fieldNavigate ??= new DelegateCommand<string>(Navigate, CanNavigate);

    private bool CanNavigate(string path) {
        return true;
    }

    private void Navigate(string path) {
        if (path == null) return;

        // TODO: Devo caricare il modulo che contiene la vista
    }

    #endregion NavigateCommand

    #region CloseAppCommand

    private DelegateCommand _fieldCloseApp;
    public DelegateCommand CloseAppCommand => _fieldCloseApp ??= new DelegateCommand(CloseApp, CanCloseApp);

    private bool CanCloseApp() {
        return true;
    }

    private void CloseApp() { }

    #endregion CloseAppCommand

    #region VoidKindAndSubkindCommand

    private DelegateCommand _fieldVoidKindAndSubkind;
    public DelegateCommand VoidKindAndSubkindCommand => _fieldVoidKindAndSubkind ??= new DelegateCommand(VoidKindAndSubkind);

    private void VoidKindAndSubkind() {
        MvLookups.Kinds.RemoveAll();
        MvLookups.SubKinds.RemoveAll();
        UpdateRootCode();
    }

    #endregion VoidKindAndSubkindCommand

    #region VoidSubkindCommand

    private DelegateCommand _fieldVoidSubkind;
    public DelegateCommand VoidSubkindCommand => _fieldVoidSubkind ??= new DelegateCommand(VoidSubkind);

    private void VoidSubkind() {
        MvLookups.SubKinds.RemoveAll();
        UpdateRootCode();
    }

    #endregion VoidSubkindCommand

    #endregion Commands
}