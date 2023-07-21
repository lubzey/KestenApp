namespace KestenApp.Data.Configurations
{    
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using KestenApp.Data.Models;

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
