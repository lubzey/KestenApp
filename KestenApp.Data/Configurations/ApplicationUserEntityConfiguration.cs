namespace KestenApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;

    using KestenApp.Data.Models;

    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder
                .Property(u => u.DisplayName)
                .HasDefaultValue("Lorem Ipsum");

            builder.HasData(SeedData.ApplicationUsers);
        }
    }
}
