namespace Domain.Model
{
    public class DevKind
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public ICollection<DevType> Subtypes { get; set; }

    }
}
