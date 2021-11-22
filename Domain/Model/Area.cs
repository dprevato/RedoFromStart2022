using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
    public class Area
    {
        public int Id { get; set; }
        public string Code { get; set; }  // indice unico su questo campo
        [StringLength(64)] public string Name { get; set; }
        [StringLength(512)] public string Description { get; set; }
        [Timestamp] public byte[] TimeStamp { get; set; }

        public ICollection<Plant> Plants { get; set; }
    }
}
