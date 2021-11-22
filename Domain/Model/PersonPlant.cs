namespace Domain.Model
{
    public class PersonPlant
    {
        public int PlantId { get; set; }
        public Guid PersonId { get; set; }
        public Plant Plant { get; set; }
        public Person Person { get; set; }
    }
}
