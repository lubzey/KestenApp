namespace KestenApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;

    using KestenApp.Data.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class SpecimenPositionEntityConfiguration : IEntityTypeConfiguration<SpecimenPosition>
    {
        public void Configure(EntityTypeBuilder<SpecimenPosition> builder)
        {
            builder
                .HasKey(p => new { p.GardenId, p.Row, p.Column });

            builder
                .ToTable("SpecimenPositions");

            builder.HasData(SeedData.SpecimenPositions);
        }
    }
}
