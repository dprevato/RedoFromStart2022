using System.ComponentModel.DataAnnotations;
using Domain.Helpers;

namespace Domain.Model
{
    public class ChartNote : ISoftDelete
    {
        public int ChartId { get; set; }
        public int Id { get; set; }
        public decimal XPos { get; set; }
        public decimal YPos { get; set; }
        [StringLength(512)] public string Message { get; set; }
        public NoteAlignment TextAlignment { get; set; }
        [StringLength(16)] public string NoteColor { get; set; }
        [Timestamp] public byte[] TimeStamp { get; set; }
        //
        public Chart Chart { get; set; }

        #region Implementation of ISoftDelete

        public bool Zap { get; set; }
        public DateTime? ZapOn { get; set; }
        public string? ZapBy { get; set; }

        #endregion
    }
}
