using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
{
    public class DeviceDetailsConfiguration : IEntityTypeConfiguration<DeviceDetail>
    {
        public void Configure(EntityTypeBuilder<DeviceDetail> e)
        {
            e.Property(x => x.ItemName).IsRequired(false);
            e.Property(x => x.ItemUoM).IsRequired(false);
            e.Property(x => x.ItemValue).IsRequired();
        }
    }
}
