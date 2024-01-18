namespace Kesten.Api.Data.Configurations
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Microsoft.EntityFrameworkCore;
    using Kesten.Api.Data;
    using Kesten.Api.Data.Models;

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
