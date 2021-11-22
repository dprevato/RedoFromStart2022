using Domain.Model;

namespace Domain.Mapping
{
    public class FormulaConfiguration : IEntityTypeConfiguration<Formula>
    {
        public void Configure(EntityTypeBuilder<Formula> e)
        {
            e.HasKey(x => x.Id);
            e.Property(x => x.Id).ValueGeneratedNever(); // Niente autoincremento
        }
    }
}
