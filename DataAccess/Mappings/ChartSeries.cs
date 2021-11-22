using Domain.Helpers;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
{
    public class ChartSeriesConfiguration : IEntityTypeConfiguration<ChartSeries>
    {
        public void Configure(EntityTypeBuilder<ChartSeries> e)
        {
            e.HasQueryFilter(x => !x.Zap);
            e.Property(x => x.SeriesType).HasConversion(x => (int)x, x => (ChartSeriesTypes)x).HasDefaultValue(ChartSeriesTypes.Line);
            e.HasIndex(x => x.DataSource).IsUnique(false);
        }
    }
}
