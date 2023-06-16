using KestenTestApp.Models.Data;
using KestenTestApp.Models.EnumHelpers;
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
                    List<RangeInt> customRanges = EnumExtensions.GetAttributes<RangeInt>(fs);
                    RangeInt? fruitsPerKg = customRanges.SingleOrDefault(r => r.Type == IntRangeEnum.FruitsPerKg);
                    RangeInt? fruitWeight = customRanges.SingleOrDefault(r => r.Type == IntRangeEnum.FruitWeight);

                    tempFruitSizes.Add(
                        new FruitSize
                        {
                            Name = fs.ToString(),
                            FruitsPerKgMin = fruitsPerKg?.Minimun,
                            FruitsPerKgMax = fruitsPerKg?.Maximum,
                            FruitsWeightMin = fruitWeight?.Minimun,
                            FruitsWeightMax = fruitWeight?.Maximum,
                        });
                }

                fruitSizes = tempFruitSizes
                    .OrderBy(fs => fs.FruitSizeId)
                    .ToArray();

                return fruitSizes;
            }
        }

        public static IReadOnlyList<Species> Species
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
                            CommonName = EnumExtensions.GetDescription(sp) ?? string.Empty,
                            LatinName = EnumExtensions.GetDisplayName(sp) ?? sp.ToString(),
                            ShortLatinName = sp.ToString(),
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
                        new Variety //1
                        {
                            VarietyName = "Bouche de Bétizac",
                            Species = sativaCrenataSpecies,
                            Description =
                                @"Bouche de Bétizac is a French chestnut cultivar developed in 1962 by INRA at the station of Malemort-sur-Corrèze near Brive. It is a controlled hybrid between Castanea sativa and Castanea crenata (female Bouche rouge × male Castanea crenata CA04). This variety produces large to very large chestnuts. It has very good flavor for a hybrid. With Marigoule, it is the variety currently most cultivated in the French chestnut groves because it is very productive (3 tons per hectare on average). Its fruit is bright, light chestnut-brown quickly turning brown and dark brown.",
                            FruitSizes = FruitSizes
                                .Where(s => s.FruitSizeId == (int)FruitSizeEnum.XL)
                                .ToList(),
                            Images = new List<Image>
                            {
                                new Image{ FileName = "BE9CCA3D-4E9A-4E75-B813-9279F79F7F75"}
                            },
                            Peeling = ConditionEnum.Good,
                            IsMarron = true,
                            ChestnutBlightResistance = ConditionEnum.Good,
                            InkDiseaseResistance = ConditionEnum.Bad,
                            MaturityPeriod = MaturingPeriodEnum.Early,
                            PollenType = PollenTypeEnum.Sterile
                        },
                        new Variety //2
                        {
                            VarietyName = "Marigoule",
                            Species = sativaCrenataSpecies,
                            Description =
                                @"Marigoule is the name of a french hybrid of chestnut (synonym M.15 or CA 15), cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata). In 1986, it originated from a Migoule orchard in Ussac in Corrèze. Marigoule (a contraction of Marron of Migoule) is a very tasty chestnut. It should be planted in rather low altitude in very sunny areas and protected from the wind (up to 300 m elevation for South-West orchard orientation or up to 400 m elevation in South-East orchard orientation). Otherwise its productivity remains small. In France, it is grown mainly South of the Dordogne and Lot-et-Garonne for the fresh market production because of the nuts beautiful appearance.",
                            FruitSizes = FruitSizes
                                .Where(s => s.FruitSizeId == (int)FruitSizeEnum.Large
                                    || s.FruitSizeId == (int)FruitSizeEnum.XL)
                                .ToList(),
                            Images = new List<Image>
                            {
                                new Image{ FileName = "BF77FF2D-A488-4F6D-847B-3C880239A53F"}
                            },
                            Peeling = ConditionEnum.Good,
                            IsMarron = true,
                            ChestnutBlightResistance = ConditionEnum.Medium,
                            InkDiseaseResistance = ConditionEnum.Good,
                            MaturityPeriod = MaturingPeriodEnum.SemiEarly,
                            PollenType = PollenTypeEnum.Medium
                        },
                        new Variety //3
                        {
                            VarietyName = "Marsol",
                            Species = sativaCrenataSpecies,
                            Description =
                                @"Marsol (aka Marisol) is a natural chestnut hybrid, a cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata) (CA 07). INRA produced this variety from Lalevade-d'Ardèche. It is mainly used as a rootstock because of its good graft compatibility with many varieties. As a rootstock, it is more vigorous than Maraval (equal to Bouche de Betizac or Comballe).",
                            FruitSizes = FruitSizes
                                .Where(s => s.FruitSizeId == (int)FruitSizeEnum.XL)
                                .ToList(),
                            Images = new List<Image>
                            {
                                new Image{ FileName = "EE93870C-A4AD-46F7-B5DC-F36AE12ED3A3"}
                            },
                            Peeling = ConditionEnum.Good,
                            IsMarron = true,
                            ChestnutBlightResistance = ConditionEnum.Good,
                            InkDiseaseResistance = ConditionEnum.Good,
                            MaturityPeriod = MaturingPeriodEnum.SemiEarly,
                            PollenType = PollenTypeEnum.Abundant
                        },
                        new Variety //4
                        {
                            VarietyName = "Précoce Migoule",
                            Species = sativaCrenataSpecies,
                            Description =
                                @"The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.",
                            FruitSizes = FruitSizes
                                .Where(s => s.FruitSizeId == (int)FruitSizeEnum.Medium
                                    || s.FruitSizeId == (int)FruitSizeEnum.Large)
                                .ToList(),
                            Peeling = ConditionEnum.Good,
                            IsMarron = true,
                            ChestnutBlightResistance = ConditionEnum.Bad,
                            InkDiseaseResistance = ConditionEnum.Medium,
                            MaturityPeriod = MaturingPeriodEnum.Early,
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

                //Pollenizers
                var pollenizer = new List<VarietyPollenCompatibility>
                {
                    new VarietyPollenCompatibility
                    {
                        PollinizerVarietyId = 2, TargetVarietyId = 1
                    },
                    new VarietyPollenCompatibility
                    {
                        PollinizerVarietyId = 3, TargetVarietyId = 1
                    },
                    new VarietyPollenCompatibility
                    {
                        PollinizerVarietyId = 4, TargetVarietyId = 1
                    }
                };
                context.VarietyPollenizers.AddRange(pollenizer);

                //Grafting
                var grafts = new List<VarietyGraftingCompatibility>
                {
                    new VarietyGraftingCompatibility
                    {
                        RootstockVarietyId = 3,
                        GraftedVarietyId = 1
                    },
                    new VarietyGraftingCompatibility
                    {
                        RootstockVarietyId = 3,
                        GraftedVarietyId = 4
                    },
                    new VarietyGraftingCompatibility
                    {
                        RootstockVarietyId = 2,
                        GraftedVarietyId = 4
                    },
                };

                context.VarietyGrafting.AddRange(grafts);

                context.SaveChanges();
            }
        }
    }
}
