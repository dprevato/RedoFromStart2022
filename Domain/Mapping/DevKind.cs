using Domain.Model;

namespace Domain.Mapping
{
    public class DevKindConfiguration : IEntityTypeConfiguration<DevKind>
    {
        public void Configure(EntityTypeBuilder<DevKind> e)
        {
            e.HasMany(x => x.Subtypes).WithOne(x => x.Kind).HasForeignKey(x => x.KindId);
        }
    }
}
