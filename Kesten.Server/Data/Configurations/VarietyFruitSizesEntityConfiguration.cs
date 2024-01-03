namespace Kesten.Server.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Kesten.Server.Data;
    using Kesten.Server.Data.Models;

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
