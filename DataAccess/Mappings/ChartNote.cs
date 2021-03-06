using Domain;
using Domain.Helpers;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
{
    public class ChartNoteConfiguration : IEntityTypeConfiguration<ChartNote>
    {
        public void Configure(EntityTypeBuilder<ChartNote> e)
        {
            e.HasQueryFilter(x => !x.Zap);
            e.Property(x => x.XPos).HasColumnType("decimal(10,4)");
            e.Property(x => x.YPos).HasColumnType("decimal(10,4)");
            e.Property(x => x.TextAlignment).HasConversion(x => (int)x, x => (NoteAlignment)x).HasDefaultValue(NoteAlignment.MiddleCenter);
        }
    }
}
