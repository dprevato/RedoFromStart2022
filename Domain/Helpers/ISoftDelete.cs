namespace Domain.Helpers
{
    public interface ISoftDelete
    {
        bool Zap { get; set; }
        DateTime? ZapOn { get; set; }
        string? ZapBy { get; set; }
    }
}
