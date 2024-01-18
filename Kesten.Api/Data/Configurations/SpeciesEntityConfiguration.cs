namespace Kesten.Api.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Kesten.Api.Data;
    using Kesten.Api.Data.Models;

    public class SpeciesEntityConfiguration : IEntityTypeConfiguration<Species>
    {
        public void Configure(EntityTypeBuilder<Species> builder)
        {
            builder.HasData(SeedData.Species);
        }
    }
}
