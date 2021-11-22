using Domain.Model;

namespace Domain.Mapping
{
    public class PdmImportConfiguration : IEntityTypeConfiguration<PdmImport>
    {
        public void Configure(EntityTypeBuilder<PdmImport> e)
        {
            e.ToTable("Pdm");
        }
    }
}
