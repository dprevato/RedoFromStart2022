using Domain.Model;

namespace Domain.Mapping
{
    public class PlantConfiguration : IEntityTypeConfiguration<Plant>
    {
        public void Configure(EntityTypeBuilder<Plant> e)
        {
            e.HasOne(x => x.Area).WithMany(x => x.Plants).HasForeignKey(x => x.AreaId);
            e.HasAlternateKey(x => x.Code);
            e.HasMany(x => x.History).WithOne(x => x.Plant).HasForeignKey(x => x.PlantId);
            e.HasMany(x => x.People).WithOne(x => x.Plant).HasForeignKey(x => x.PlantId);
            e.HasMany(x => x.Details).WithOne(x => x.Plant).HasForeignKey(x => x.PlantId);
        }
    }
}
