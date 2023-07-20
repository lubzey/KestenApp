namespace KestenApp.Data.Configurations
{
    using KestenApp.Data.Enums;
    using KestenApp.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class VarietySpeciesEntityConfiguration : IEntityTypeConfiguration<VarietySpecies>
    {
        public void Configure(EntityTypeBuilder<VarietySpecies> builder)
        {
            builder
                .HasOne(e => e.Variety)
                .WithMany(e => e.Species)
                .HasForeignKey(x => x.VarietyId);

            builder
                .HasOne(e => e.Species)
                .WithMany(e => e.Varieties)
                .HasForeignKey(x => x.SpeciesId);

            builder.HasData(this.GenerateVarietySpecies());
        }

        private VarietySpecies[] GenerateVarietySpecies()
        {
            return new VarietySpecies[]{
                new VarietySpecies {
                    VarietySpeciesId = 1,
                    VarietyId = Guid.Parse("46BD8DC8-CA0A-4648-A9A9-EA4AD91E1B77"),
                    SpeciesId = (int)SpeciesTypeEnum.Sativa
                },
                new VarietySpecies {
                    VarietySpeciesId = 2,
                    VarietyId = Guid.Parse("46BD8DC8-CA0A-4648-A9A9-EA4AD91E1B77"),
                    SpeciesId = (int)SpeciesTypeEnum.Crenata
                }
            };
        }
    }
}
