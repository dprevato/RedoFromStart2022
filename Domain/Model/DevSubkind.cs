namespace Domain.Model
{
    public class DevSubkind
    {
        public string KindId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public DevKind Kind { get; set; }
    }
}
