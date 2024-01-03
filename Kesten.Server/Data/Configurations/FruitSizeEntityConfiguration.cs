namespace Kesten.Server.Data.Configurations
{
    using Kesten.Server.Data;
    using Kesten.Server.Data.Models;
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
