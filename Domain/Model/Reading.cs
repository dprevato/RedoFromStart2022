using Domain.Helpers;

namespace Domain.Model
{
    public class Reading : ISoftDelete
    {
        public int Id { get; set; }
        public int PdmId { get; set; }
        public DateTime ReadOn { get; set; }
        public string Message { get; set; }
        public decimal ReadValue { get; set; }
        public DateTime TakenOn { get; set; }
        public bool Validated { get; set; }
        public DateTime ValidatedOn { get; set; }
        public int ValidatedBy { get; set; }
        //
        public Pdm Pdm { get; set; }

        #region Implementation of ISoftDelete

        public bool Zap { get; set; }
        public DateTime? ZapOn { get; set; }
        public string? ZapBy { get; set; }

        #endregion
    }
}
