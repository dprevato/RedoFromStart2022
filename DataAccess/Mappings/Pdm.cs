using Domain.Helpers;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
{
    public class PdmConfiguration : IEntityTypeConfiguration<Pdm>
    {
        public void Configure(EntityTypeBuilder<Pdm> e)
        {
            e.ToTable("Pdm");
            e.HasAlternateKey(x => x.Code);
            e.Property(x => x.Status).HasConversion(x => (int)x, x => (StatusValues)x);
            e.Property(x => x.InitValue).HasColumnType("decimal(10,4)");
            e.Property(x => x.WarningHi).HasColumnType("decimal(10,4)");
            e.Property(x => x.WarningLo).HasColumnType("decimal(10,4)");
            e.Property(x => x.AlarmHi).HasColumnType("decimal(10,4)");
            e.Property(x => x.AlarmLo).HasColumnType("decimal(10,4)");
        }
    }
}
