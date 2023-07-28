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
               .Property(v => v.DateCreated)
               .HasDefaultValueSql("GETDATE()");

            builder
                .HasMany(v => v.Specimens)
                .WithOne(v => v.Garden)
                .HasForeignKey(e => e.SpecimenId);

            builder
                .ToTable("Gardens");

            builder.HasData(SeedData.Gardens);
        }
    }
}
