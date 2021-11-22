using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> e)
        {
            e.Property(x => x.UserLevel).HasConversion(x => (global::Domain.Helpers.Grants) x, x => (int) x);
            e.HasOne(x => x.Person).WithOne().HasForeignKey<AppUser>(x => x.PersonFk);
        }
    }
}
