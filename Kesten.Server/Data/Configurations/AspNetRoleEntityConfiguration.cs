namespace Kesten.Server.Data.Configurations
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;
    using Kesten.Server.Data;

    public class AspNetRoleEntityConfiguration : IEntityTypeConfiguration<IdentityRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
        {
            builder
                .ToTable("AspNetRoles");

            builder.HasData(SeedData.IdentityRoles);
        }
    }
}