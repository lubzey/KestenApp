namespace Kesten.Api.Data.Configurations
{
    using Kesten.Api.Data;
    using Kesten.Api.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class FruitSizeEntityConfiguration : IEntityTypeConfiguration<FruitSize>
    {
        public void Configure(EntityTypeBuilder<FruitSize> builder)
        {
            builder.HasData(SeedData.FruitSizes);
        }
    }
}
