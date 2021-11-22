using Domain.Helpers;

namespace Domain.Model
{
    public class Pdm : ISoftDelete
    {
        public Pdm() => Code = string.Concat(Device.Code, Channel);

        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string Channel { get; set; } // codice Pdm da accodare al codice Device
        public string Code { get; init; }    // campo calcolato, Device.Code+Channel
        public string Tag { get; set; }     // Codice di targa
        public string Name { get; set; }
        public DateTime InstalledOn { get; set; }
        public DateTime? DismissedOn { get; set; }
        public decimal InitValue { get; set; }
        public bool Fake { get; set; }
        public bool NoReport { get; set; }
        public StatusValues Status { get; set; } // Deve mappare un campo di nome PdmStatus
        public byte[] TimeStamp { get; set; }
        //
        public decimal WarningLo { get; set; }
        public decimal WarningHi { get; set; }
        public decimal AlarmLo { get; set; }
        public decimal AlarmHi { get; set; }
        //
        public bool AutoImport { get; set; }     // Pdm a importazione automatica
        public bool CanImport { get; set; }      // Importazione possibile
        public int FormulaId { get; set; }       // Formula di ingegnerizzazione
        public DateTime LastImportOn { get; set; } // Data ultima importazione
        public string TableMap { get; set; }     // Nome della tabella origine (obsoleto)
        public string FieldMap { get; set; }     // Nome del campo origine (obsoleto)
        //
        public Formula Formula { get; set; } // Formula di ingegnerizzazione
        public ICollection<FormulaArgument> Args { get; set; }
        public string FieldValue { get; set; }
        //
        public ICollection<Reading> Readings { get; set; }
        public ICollection<FormulaArgument> Arguments { get; set; }
        public Plant Plant { get; set; }
        public Device Device { get; set; }


        public bool Zap { get; set; }
        public DateTime zapDate { get; set; }
        public string zapper { get; set; }
    }

    public class PdmThreshold
    {
        public int Id { get; set; }
        public decimal WarningLo { get; set; }
        public decimal WarningHi { get; set; }
        public decimal AlarmLo { get; set; }
        public decimal AlarmHi { get; set; }
    }

    public class PdmImport
    {
        public int Id { get; set; }
        public bool AutoImport { get; set; } // Pdm a importazione automatica
        public bool CanImport { get; set; } // Importazione possibile
        public int FormulaId { get; set; } // Formula di ingegnerizzazione
        public DateTime LastImportOn { get; set; } // Data ultima importazione
        public string TableMap { get; set; } // Nome della tabella origine (obsoleto)
        public string FieldMap { get; set; } // Nome del campo origine (obsoleto)
        //
        public Formula Formula { get; set; } // Formula di ingegnerizzazione
        public ICollection<FormulaArgument> Args { get; set; }
        public string FieldValue { get; set; }
    }
}
