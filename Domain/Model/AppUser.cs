using System.ComponentModel.DataAnnotations;
using Domain.Helpers;

namespace Domain.Model
{
    public class AppUser : ISoftDelete
    {
        public int PersonId { get; set; }
        public int Id { get; set; }
        public string LoginName { get; set; }
        public int UserLevel { get; set; }
        public DateTime? FirstLoginOn { get; set; }
        [Timestamp] public byte[] TimeStamp { get; set; }

        //
        public Person Person { get; set; }

        public bool Zap { get; set; }
        public DateTime? ZapOn { get; set; }
        public string ZapBy { get; set; }
    }
}
