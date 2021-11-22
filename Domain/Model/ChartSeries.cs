using System.ComponentModel.DataAnnotations;
using Domain.Helpers;

namespace Domain.Model
{
    public class ChartSeries : ISoftDelete
    {
        public int ChartId { get; set; }
        public int Id { get; set; }
        public ChartSeriesTypes SeriesType { get; set; } // default 0 = curva; 1 = istogramma
        public string SeriesColor { get; set; }
        [StringLength(16)] public string SeriesLabel { get; set; }
        [StringLength(32)] public string DataSource { get; set; }
        [Timestamp] public byte[] TimeStamp { get; set; }
        //
        public Chart Chart { get; set; }

        public bool Zap { get; set; }
        public DateTime? ZapOn { get; set; }
        public string ZapBy { get; set; }
    }
}
