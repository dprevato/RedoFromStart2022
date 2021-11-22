using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
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
