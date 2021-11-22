using Domain.Helpers;

namespace Domain.Model
{
    public class StatusHistory
    {
        public int Id { get; set; }
        public string PdmCode { get; set; }
        public StatusValues Status { get; set; }
        public string StatusMessage { get; set; }
        public DateTime ChangedOn { get; set; }
    }
}
