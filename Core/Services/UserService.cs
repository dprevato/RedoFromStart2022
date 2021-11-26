using Domain;

namespace Core.Services;

public interface IUserService
{
    public string Name {get; set; }
    public string Domain {get; set; }
    public Grants Grant {get; set; }
    public bool Guest();
    public bool User();
    public bool PowerUser();
    public bool Admin();
    public bool SuperAdmin();
}

public class UserService : IUserService
{
    #region Overrides of Object

    public override string ToString() => $@"{Domain}\{Name}";

    #endregion

    #region Implementation of IUserService
    public bool Guest() => Grant == Grants.Guest;
    public bool User() => Grant != Grants.Guest;
    public bool PowerUser() => Grant >= Grants.PowerUser;
    public bool Admin() => Grant >= Grants.Admin;
    public bool SuperAdmin() => Grant == Grants.SuperAdmin;
    public string Name { get; set; } = "danie";
    public string Domain { get; set; } = "GANDALF";
    public Grants Grant { get; set; } = Grants.SuperAdmin;

    #endregion
}