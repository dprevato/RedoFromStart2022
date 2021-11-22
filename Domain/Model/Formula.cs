namespace Domain.Model
{
    public class Formula
    {
        public int Id { get; set; }
        public string FormulaText { get; set; }
        public int ArgsCount { get; set; }

        public PdmImport Pdm { get; set; }
    }
}
