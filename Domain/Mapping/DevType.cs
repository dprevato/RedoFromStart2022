using Domain.Model;

namespace Domain.Mapping
{
    public class DevTypeConfiguration : IEntityTypeConfiguration<DevType>
    {
        public void Configure(EntityTypeBuilder<DevType> e)
        {
            e.HasOne(x => x.Kind).WithMany().HasForeignKey(x => x.KindId);
        }
    }
}
