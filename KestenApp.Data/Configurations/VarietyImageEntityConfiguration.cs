namespace KestenApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using KestenApp.Data.Models;
    using Microsoft.EntityFrameworkCore;

    internal class VarietyImageEntityConfiguration : IEntityTypeConfiguration<VarietyImage>
    {
        public void Configure(EntityTypeBuilder<VarietyImage> builder)
        {
            builder
                .HasOne(vi => vi.Variety)
                .WithMany(v => v.VarietyImages)
                .HasForeignKey(e => e.VarietyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .ToTable("VarietyImages");

            builder.HasData(SeedData.VarietyImages);
        }
    }
}
