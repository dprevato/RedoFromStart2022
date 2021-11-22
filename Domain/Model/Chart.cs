using System.ComponentModel.DataAnnotations;
using Domain.Helpers;

namespace Domain.Model
{
    public class Chart : ISoftDelete
    {
        public int DocId { get; set; }
        public int Id { get; set; }
        [StringLength(64)] public string Title { get; set; }
        [StringLength(32)] public string YAxisTitle { get; set; }
        public int MinY { get; set; }
        public int MaxY { get; set; }
        public bool Legend { get; set; }
        public int PrintOrder { get; set; }

        //
        public ChartDoc ChartDoc { get; set; }
        public ICollection<ChartSeries> ChartSeries { get; set; }
        public ICollection<ChartNote> Annotations { get; set; }

        #region Implementation of ISoftDelete

        public bool Zap { get; set; }
        public DateTime? ZapOn { get; set; }
        public string? ZapBy { get; set; }

        #endregion
    }
}
