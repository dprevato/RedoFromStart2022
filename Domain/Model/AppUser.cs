using System.ComponentModel.DataAnnotations;
using Domain.Helpers;

namespace Domain.Model
{
    public class AppUser : ISoftDelete
    {
        [Required] public int PersonFk { get; set; }
        public int Id { get; set; }
        [Required] public string LoginName { get; set; } = string.Empty;
        public int UserLevel { get; set; }
        public DateTime? FirstLoginOn { get; set; }

        //
        public Person Person { get; set; } = new Person();

        #region Implementation of ISoftDelete
        public bool Zap { get; set; }
        public DateTime? ZapOn { get; set; }
        public string? ZapBy { get; set; }

        #endregion Implementation of ISoftDelete
    }
}
