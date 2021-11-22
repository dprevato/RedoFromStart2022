using System.ComponentModel.DataAnnotations;
using Domain.Helpers;

namespace Domain.Model
{
    public class ChartDoc : ISoftDelete
    {
        public int Id { get; set; }
        [StringLength(16)] public string Code { get; set; }
        [StringLength(64)] public string Title { get; set; }
        [StringLength(64)] public string SubTitle { get; set; }
        public bool FirstBigger { get; set; }
        [StringLength(16)] public string DocOwner { get; set; }
        public int PrintOrder { get; set; }
        [Timestamp] public byte[] TimeStamp { get; set; }
        public ICollection<Chart> Charts { get; set; }

        #region Implementation of ISoftDelete

        public bool Zap { get; set; }
        public DateTime? ZapOn { get; set; }
        public string? ZapBy { get; set; }

        #endregion
    }
}
