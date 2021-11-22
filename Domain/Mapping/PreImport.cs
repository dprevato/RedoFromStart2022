using Domain.Model;

namespace Domain.Mapping
{
    public class PreImportConfiguration : IEntityTypeConfiguration<PreImport>
    {
        public void Configure(EntityTypeBuilder<PreImport> e)
        {
            e.HasKey(x => x.PdmCode);
            e.HasOne(x => x.Pdm).WithMany().HasForeignKey(x => x.PdmCode);
        }
    }
}
