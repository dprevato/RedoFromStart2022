using Domain.Model;

namespace Domain.Mapping
{
    public class PdmThresholdConfiguration : IEntityTypeConfiguration<PdmThreshold>
    {
        public void Configure(EntityTypeBuilder<PdmThreshold> e)
        {
            e.ToTable("Pdm");
        }
    }
}
