namespace Domain.Model
{
    public class PreImport
    {
        public string PdmCode { get; set; }
        public DateTime ReadOn { get; set; }
        public string Message { get; set; }
        public decimal ReadValue { get; set; }
        public DateTime TakenOn { get; set; }

        public Pdm Pdm { get; set; }    
    }
}
