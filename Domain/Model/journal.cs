using System.ComponentModel.DataAnnotations;
using Domain.Helpers;

namespace Domain.Model
{
    public class Journal : ISoftDelete
    {
        public int PlantId { get; set;}
        public int Id { get; set; }
        public DateTime AnnotationDate { get; set; }
        [StringLength(4000)] public string Annotation { get; set; }
        [Timestamp] public byte[] TimeStamp { get; set; }

        public Plant Plant { get; set; }

        #region Implementation of ISoftDelete

        public bool Zap { get; set; }
        public DateTime? ZapOn { get; set; }
        public string? ZapBy { get; set; }

        #endregion
    }
}
