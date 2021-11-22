using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
{
    public class PdmThresholdConfiguration : IEntityTypeConfiguration<PdmThreshold>
    {
        public void Configure(EntityTypeBuilder<PdmThreshold> e)
        {
            e.ToTable("Pdm");
        }
    }
}
