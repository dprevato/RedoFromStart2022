using Domain.Model;

namespace Domain.Mapping
{
    public class AreaConfiguration : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> e)
        {
            e.HasAlternateKey(x => x.Code);
            e.HasMany(x => x.Plants).WithOne(x => x.Area).HasForeignKey(x => x.AreaId);
        }
    }
}
