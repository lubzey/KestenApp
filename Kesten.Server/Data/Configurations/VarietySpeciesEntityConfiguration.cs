namespace Kesten.Server.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Kesten.Server.Data;
    using Kesten.Server.Data.Models;

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
