namespace Kesten.Api.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Kesten.Api.Data;
    using Kesten.Api.Data.Models;

    public class VarietySpeciesEntityConfiguration : IEntityTypeConfiguration<VarietySpecies>
    {
        public void Configure(EntityTypeBuilder<VarietySpecies> builder)
        {
            builder
                .HasKey(e => new
                {
                    e.VarietyId,
                    e.SpeciesId
                });

            builder.HasData(SeedData.VarietySpecies);
        }
    }
}
