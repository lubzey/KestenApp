namespace KestenApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using KestenApp.Data.Enums;
    using KestenApp.Data.Enums.EnumHelpers;
    using KestenApp.Data.Models;

    public class SpeciesEntityConfiguration : IEntityTypeConfiguration<Species>
    {
        public void Configure(EntityTypeBuilder<Species> builder)
        {
            builder.HasData(this.GenerateSpecies());
        }

        private Species[] GenerateSpecies()
        {
            var species = new List<Species>();

            foreach (SpeciesTypeEnum sp in (SpeciesTypeEnum[])Enum.GetValues(typeof(SpeciesTypeEnum)))
            {
                species.Add(
                    new Species
                    {
                        SpeciesId = (int)sp,
                        CommonName = sp.GetDescription() ?? string.Empty,
                        LatinName = sp.GetDisplayName() ?? sp.ToString(),
                        ShortLatinName = sp.ToString(),
                    });
            }

            return species.ToArray();
        }
    }
}
