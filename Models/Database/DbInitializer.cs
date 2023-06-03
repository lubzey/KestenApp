using KestenTestApp.Models.Enums;

namespace KestenTestApp.Models.Database
{
    public static class DbInitializer
    {
        private static FruitSize[]? fruitSizes;
        private static Species[]? species;
        private static Variety[]? varieties;

        public static FruitSize[] FruitSizes
        {
            get
            {
                if (fruitSizes != null)
                {
                    return fruitSizes;
                }

                var tempFruitSizes = new List<FruitSize>();
                var fruitSizeEnumValues = (FruitSizeEnum[])Enum.GetValues(typeof(FruitSizeEnum));
                foreach (FruitSizeEnum fs in fruitSizeEnumValues)
                {
                    tempFruitSizes.Add(
                        new FruitSize
                        {
                            Name = fs.ToString()
                        });
                }

                fruitSizes = tempFruitSizes.ToArray();

                return fruitSizes;
            }
        }

        public static Species[] Species
        {
            get
            {
                if (species != null)
                {
                    return species;
                }

                var tempSpecies = new List<Species>();

                foreach (SpeciesEnum sp in (SpeciesEnum[])Enum.GetValues(typeof(SpeciesEnum)))
                {
                    tempSpecies.Add(
                        new Species
                        {
                            //SpeciesId = (int)sp,
                            CommonName = EnumExtensions.GetDescription(sp) ?? string.Empty,
                            LatinName = EnumExtensions.GetDisplayName(sp) ?? sp.ToString(),
                        });
                }

                species = tempSpecies.ToArray();

                return species;
            }
        }

        public static Variety[] Varieties
        {
            get
            {
                if (varieties != null)
                {
                    return varieties;
                }

                var sativaCrenataSpecies = Species
                        .Where(s => (SpeciesEnum)s.SpeciesId == SpeciesEnum.Sativa
                            || (SpeciesEnum)s.SpeciesId == SpeciesEnum.Crenata)
                        .ToList();

                varieties = new Variety[]
                {
                        new Variety
                        {
                            VarietyName = "Bouche de Bétizac",
                            Species = sativaCrenataSpecies,
                            Description =
                                @"Bouche de Bétizac is a French chestnut cultivar developed in 1962 by INRA at the station of Malemort-sur-Corrèze near Brive. It is a controlled hybrid between Castanea sativa and Castanea crenata (female Bouche rouge × male Castanea crenata CA04). This variety produces large to very large chestnuts. It has very good flavor for a hybrid. With Marigoule, it is the variety currently most cultivated in the French chestnut groves because it is very productive (3 tons per hectare on average). Its fruit is bright, light chestnut-brown quickly turning brown and dark brown.",
                            FruitSizes = FruitSizes
                                .Where(s => s.Name == FruitSizeEnum.XL.ToString())
                                .ToList(),
                            Peeling = ConditionEnum.Good,
                            IsMarron = true,
                            ChestnutBlightResistance = ConditionEnum.Good,
                            InkDiseaseResistance = ConditionEnum.Good,
                            MaturingPeriod = MaturingPeriodEnum.Early,
                            PollenType = PollenTypeEnum.Sterile
                        },
                        new Variety
                        {
                            VarietyName = "Marigoule",
                            Species = sativaCrenataSpecies,
                            Description =
                                @"Marigoule is the name of a french hybrid of chestnut (synonym M.15 or CA 15), cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata). In 1986, it originated from a Migoule orchard in Ussac in Corrèze. Marigoule (a contraction of Marron of Migoule) is a very tasty chestnut. It should be planted in rather low altitude in very sunny areas and protected from the wind (up to 300 m elevation for South-West orchard orientation or up to 400 m elevation in South-East orchard orientation). Otherwise its productivity remains small. In France, it is grown mainly South of the Dordogne and Lot-et-Garonne for the fresh market production because of the nuts beautiful appearance.",
                            FruitSizes = FruitSizes
                                .Where(s => s.Name == FruitSizeEnum.Large.ToString()
                                    || s.Name == FruitSizeEnum.XL.ToString())
                                .ToList(),
                            Peeling = ConditionEnum.Good,
                            IsMarron = true,
                            ChestnutBlightResistance = ConditionEnum.Medium,
                            InkDiseaseResistance = ConditionEnum.Good,
                            MaturingPeriod = MaturingPeriodEnum.SemiEarly,
                            PollenType = PollenTypeEnum.Medium
                        },
                        new Variety { VarietyName = "Pandora" }
                };

                return varieties;
            }
        }

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            KestenDbContext context = applicationBuilder
                .ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<KestenDbContext>();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            if (!context.Species.Any())
            {
                context.Species.AddRange(Species);
                context.SaveChanges();
            }

            if (!context.FruitSizes.Any())
            {
                context.FruitSizes.AddRange(FruitSizes);
                context.SaveChanges();
            }

            if (!context.Varieties.Any())
            {
                context.Varieties.AddRange(Varieties);                
                context.SaveChanges();

                var pollenizer = new PollenizerTarget() { PollinizerVarietyId = 2, TargetVarietyId = 1 };

                context.PollenizerTargets.Add(pollenizer);
                context.SaveChanges();
            }

            //context.SaveChanges();
        }
    }
}
