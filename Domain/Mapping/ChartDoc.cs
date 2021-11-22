﻿using Domain.Model;

namespace Domain.Mapping
{
    public class ChartDocConfiguration : IEntityTypeConfiguration<ChartDoc>
    {
        public void Configure(EntityTypeBuilder<ChartDoc> e)
        {
            e.HasIndex(x => x.Code).IsUnique(false);
            e.HasQueryFilter(x => !x.Zap);
            e.Property(x => x.Id).ValueGeneratedNever();
            e.Property(x => x.Title).IsRequired();
            e.HasMany(x => x.Charts).WithOne(x => x.ChartDoc).HasForeignKey(x => x.DocId);
        }
    }
}
