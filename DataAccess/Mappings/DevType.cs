using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
{
    public class DevTypeConfiguration : IEntityTypeConfiguration<DevType>
    {
        public void Configure(EntityTypeBuilder<DevType> e)
        {
            e.HasOne(x => x.Kind).WithMany().HasForeignKey(x => x.KindId);
        }
    }
}
