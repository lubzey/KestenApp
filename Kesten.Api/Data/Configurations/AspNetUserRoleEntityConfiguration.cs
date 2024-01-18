namespace Kesten.Api.Data.Configurations
{
    using Kesten.Api.Data;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AspNetUserRoleEntityConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder
                .ToTable("AspNetUserRoles");

            builder.HasData(SeedData.IdentityUserRoles);
        }
    }
}
