﻿namespace Kesten.Server.Data.Configurations
{
    using Kesten.Server.Data;
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
