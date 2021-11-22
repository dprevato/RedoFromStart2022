using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
{
    public class DevKindConfiguration : IEntityTypeConfiguration<DevKind>
    {
        public void Configure(EntityTypeBuilder<DevKind> e)
        {
            e.HasMany(x => x.Subtypes).WithOne(x => x.Kind).HasForeignKey(x => x.KindId);
        }
    }
}
