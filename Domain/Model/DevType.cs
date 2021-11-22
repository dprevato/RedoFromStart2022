namespace Domain.Model
{
    public class DevType
    {
        public string KindId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public DevKind Kind { get; set; }
    }
}
