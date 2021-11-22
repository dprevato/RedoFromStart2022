namespace Domain.Helpers
{
    public interface ISoftDelete
    {
        bool Zap { get; set; }
        DateTime zapDate { get; set; }
        string zapper { get; set; }
    }
}
