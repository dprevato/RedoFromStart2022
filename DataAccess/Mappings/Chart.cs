using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
{
    public class ChartConfiguration : IEntityTypeConfiguration<Chart>
    {
        public void Configure(EntityTypeBuilder<Chart> e)
        {
            e.Property(x => x.Id).ValueGeneratedNever();
            e.HasQueryFilter(x => !x.Zap);
            e.HasMany(x => x.ChartSeries).WithOne(x => x.Chart).HasForeignKey(x => x.ChartId);
            e.HasMany(x => x.Annotations).WithOne(x => x.Chart).HasForeignKey(x => x.ChartId);
        }
    }
}
