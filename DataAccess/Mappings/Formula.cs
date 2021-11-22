using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
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
