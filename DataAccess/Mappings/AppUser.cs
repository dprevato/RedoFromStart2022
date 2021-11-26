using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> e)
        {
            e.HasOne(x => x.Person).WithOne().HasForeignKey<AppUser>(x => x.PersonFk);
        }
    }
}
