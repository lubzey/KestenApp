namespace Kesten.Api.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Kesten.Api.Data;
    using Kesten.Api.Data.Models;

    internal class VarietyFruitSizesEntityConfiguration : IEntityTypeConfiguration<VarietyFruitSize>
    {
        public void Configure(EntityTypeBuilder<VarietyFruitSize> builder)
        {
            builder
                .HasKey(e => new
                {
                    e.VarietyId,
                    e.FruitSizeId
                });

            builder
                .ToTable("VarietyFruitSizes");

            builder.HasData(SeedData.VarietyFruitSizes);
        }
    }
}
