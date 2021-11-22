namespace Domain.Model
{
    public class FormulaArgument
    {
        public int Id { get; set; }
        public string PdmCode { get; set; }
        public int ArgPos { get; set; }
        public decimal ArgValue { get; set; }

        public Pdm Pdm { get; set; }
    }
}
