using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
{
    public class DeviceConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> e)
        {
            e.Property(x => x.Code).HasComputedColumnSql("[PlantCode]+[KindId]+[TypeId]+[Instance]", stored: true);
            e.HasAlternateKey(x => x.Code);
        }
    }
}
