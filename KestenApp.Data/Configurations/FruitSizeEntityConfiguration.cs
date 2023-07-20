namespace KestenApp.Data.Configurations
{
    using KestenApp.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class FruitSizeEntityConfiguration : IEntityTypeConfiguration<FruitSize>
    {
        public void Configure(EntityTypeBuilder<FruitSize> builder)
        {
            builder.HasData(SeedData.GetFruitSizes());
        }
    }
}
