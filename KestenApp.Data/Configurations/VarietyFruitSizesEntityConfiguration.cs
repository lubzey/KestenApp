namespace KestenApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using KestenApp.Data.Models;

    internal class VarietyFruitSizesEntityConfiguration : IEntityTypeConfiguration<VarietyFruitSize>
    {
        public void Configure(EntityTypeBuilder<VarietyFruitSize> builder)
        {
            builder
                .HasKey(e => new
                {
                    e.VarietyId, e.FruitSizeId
                });

            builder.HasData(SeedData.VarietyFruitSizes);
        }
    }
}
