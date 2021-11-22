using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
{
    public class PdmImportConfiguration : IEntityTypeConfiguration<PdmImport>
    {
        public void Configure(EntityTypeBuilder<PdmImport> e)
        {
            e.ToTable("Pdm");
        }
    }
}
