using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
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
