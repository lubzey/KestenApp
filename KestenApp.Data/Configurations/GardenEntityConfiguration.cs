namespace KestenApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;

    using KestenApp.Data.Models;

    public class GardenEntityConfiguration : IEntityTypeConfiguration<Garden>
    {
        public void Configure(EntityTypeBuilder<Garden> builder)
        {
            builder
               .Property(g => g.DateCreated)
               .HasDefaultValueSql("GETDATE()");

            builder
                .HasMany(g => g.Specimens)
                .WithOne(g => g.Garden)
                .HasForeignKey(e => e.SpecimenId);

            builder
                .ToTable("Gardens");

            builder.HasData(SeedData.Gardens);
        }
    }
}
