using System.ComponentModel.DataAnnotations;
using Domain.Helpers;

namespace Domain.Model
{
    public class PlantDetail : ISoftDelete
    {
        public int PlantId { get; set; }
        public int Id { get; set; }
        [StringLength(256)] public string ItemName { get; set; }
        [StringLength(32)] public string ItemUm { get; set; }
        [StringLength(256)] public string ItemValue { get; set; }
        [Timestamp] public byte[] TimeStamp { get; set; }
        //
        public Plant Plant { get; set; }

        #region Implementation of ISoftDelete

        public bool Zap { get; set; }
        public DateTime? ZapOn { get; set; }
        public string? ZapBy { get; set; }

        #endregion
    }
}
