namespace Domain.Mapping
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> e)
        {
            e.Property(x => x.UserLevel).HasConversion(x => (global::Model.Enums.UserLevels) x, x => (int) x);
            e.HasOne(x => x.Person).WithOne().HasForeignKey<AppUser>(x => x.PersonId);
        }
    }
}
