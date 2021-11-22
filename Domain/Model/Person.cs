using System.ComponentModel.DataAnnotations;
using Domain.Helpers;

namespace Domain.Model
{
    public class Person : ISoftDelete
    {
        public Guid Id { get; set; }
        [StringLength(32)] public string LastName { get; set; }
        [StringLength(32)] public string FirstName { get; set; }
        [StringLength(16)] public string Code { get; set; } // codice fiscale
        public DateTime HiredOn { get; set; }
        public DateTime? RetiredOn { get; set; }
        public Guid BossId { get; set; }
        public int AreaId { get; set; } // Area in cui opera
        public byte[] TimeStamp { get; set; }

        public Person Boss { get; set; }
        public Area Area { get; set; }  // Area in cui lavora il tizio
        public ICollection<PersonPlant> Plants { get; set; }
        public AppUser AppUser { get; set; } // Non è obbligatoria

        public bool Zap { get; set; }
        public DateTime? ZapOn { get; set; }
        public string ZapBy { get; set; }
    }
}
