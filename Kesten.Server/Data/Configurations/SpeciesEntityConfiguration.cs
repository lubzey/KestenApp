namespace Kesten.Server.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Kesten.Server.Data;
    using Kesten.Server.Data.Models;

    public class SpeciesEntityConfiguration : IEntityTypeConfiguration<Species>
    {
        public void Configure(EntityTypeBuilder<Species> builder)
        {
            builder.HasData(SeedData.Species);
        }
    }
}
