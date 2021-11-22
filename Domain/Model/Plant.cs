using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
    public class Plant
    {
        public int Id { get; set; }
        public string Code { get; set; } // indice unico qui
        public int AreaId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Founded { get; set; }
        public DateTime Dismissed { get; set; }
        public decimal MaxLevel { get; set; }
        public decimal MinLevel { get; set; }
        [Timestamp] public byte[] TimeStamp { get; set; }

        public Area Area { get; set; }
        public ICollection<Journal> History { get; set; }
        public ICollection<PlantDetail> Details { get; set; }
        public ICollection<PersonPlant> People { get; set; }

    }
}
