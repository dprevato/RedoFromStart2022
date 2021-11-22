using JetBrains.Annotations;
using System.ComponentModel.DataAnnotations;
using Domain.Helpers;

namespace Domain.Model
{
    public class Device : ISoftDelete
    {
        public int Id { get; set; }
        [StringLength(8)] public int PlantCode { get; set; }
        [StringLength(8)] public string KindId { get; set; }
        [StringLength(8)] public string TypeId { get; set; }
        [StringLength(8)] public string Instance { get; set; }
        [StringLength(32)] public string Code { get; [UsedImplicitly] private set; } // campo calcolato - PlantCode+KindId+TypeId+Instance

        [StringLength(16)] public string Tag { get; set; }   // Codice di targa (antico codice Pdm)
        [StringLength(64)] public string Batch { get; set; } // Raggruppamento di cui fa parte nei report
        [StringLength(64)] public string Name { get; set; }  // Definizione del device
        public DateTime Installed { get; set; }
        public DateTime? Dismissed { get; set; }
        [StringLength(16)] public string UnitOfMeasurement { get; set; }
        public bool Fake { get; set; }
        public bool NoReport { get; set; }
        public bool NoValidation { get; set; }
        [Timestamp] public byte[] TimeStamp { get; set; }
        //
        public ICollection<Pdm> Pdms { get; set; }
        public ICollection<DeviceDetail> Details { get; set; }

        public Plant Plant { get; set; }
        public DevKind DevKind { get; set; }
        public DevType DevType { get; set; }

        #region Implementation of ISoftDelete

        public bool Zap { get; set; }
        public DateTime? ZapOn { get; set; }
        public string? ZapBy { get; set; }

        #endregion
    }
}
