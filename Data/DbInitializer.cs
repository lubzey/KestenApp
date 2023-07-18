using KestenApp.Data.Enums;
using KestenApp.Data.Enums.EnumHelpers;
using KestenApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace KestenApp.Data
{
    public static class DbInitializer
    {
        private static FruitSize[]? fruitSizes;
        private static Species[]? species;
        private static Variety[]? varieties;
        private static List<string> names = new List<string>()
        {
            "Bouche de Bétizac",
            "Marigoule",
            "Marsol",
            "Précoce Migoule",
        };

        public static FruitSize[] FruitSizes
        {
            get
            {
                if (fruitSizes != null)
                {
                    return fruitSizes;
                }

                var tempFruitSizes = new List<FruitSize>();
                var fruitSizeEnumValues = (FruitSizeTypeEnum[])Enum.GetValues(typeof(FruitSizeTypeEnum));

                foreach (FruitSizeTypeEnum fs in fruitSizeEnumValues)
                {
                    List<RangeInt> customRanges = fs.GetAttributes<RangeInt>();
                    RangeInt? fruitsPerKg = customRanges.SingleOrDefault(r => r.Type == IntRangeTypeEnum.FruitsPerKg);
                    RangeInt? fruitWeight = customRanges.SingleOrDefault(r => r.Type == IntRangeTypeEnum.FruitWeight);

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

                foreach (SpeciesTypeEnum sp in (SpeciesTypeEnum[])Enum.GetValues(typeof(SpeciesTypeEnum)))
                {
                    tempSpecies.Add(
                        new Species
                        {
                            CommonName = sp.GetDescription() ?? string.Empty,
                            LatinName = sp.GetDisplayName() ?? sp.ToString(),
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
                        .Where(s => (SpeciesTypeEnum)s.SpeciesId == SpeciesTypeEnum.Sativa
                            || (SpeciesTypeEnum)s.SpeciesId == SpeciesTypeEnum.Crenata)
                        .ToList();

                varieties = new Variety[]
                {
                        new Variety //1
                        {
                            Name = names[0], //"Bouche de Bétizac"
                            Species = sativaCrenataSpecies,
                            Description =
                                @"Bouche de Bétizac is a French chestnut cultivar developed in 1962 by INRA at the station of Malemort-sur-Corrèze near Brive. It is a controlled hybrid between Castanea sativa and Castanea crenata (female Bouche rouge × male Castanea crenata CA04). This variety produces large to very large chestnuts. It has very good flavor for a hybrid. With Marigoule, it is the variety currently most cultivated in the French chestnut groves because it is very productive (3 tons per hectare on average). Its fruit is bright, light chestnut-brown quickly turning brown and dark brown.",
                            FruitSizes = FruitSizes
                                .Where(s => s.FruitSizeId == (int)FruitSizeTypeEnum.XL)
                                .ToList(),
                            Images = new List<Image>
                            {
                                new Image{ FileName = "BE9CCA3D-4E9A-4E75-B813-9279F79F7F75"}
                            },
                            Peeling = ConditionTypeEnum.Good,
                            IsMarron = true,
                            ChestnutBlightResistance = ConditionTypeEnum.Good,
                            InkDiseaseResistance = ConditionTypeEnum.Bad,
                            MaturityPeriod = PeriodTypeEnum.Early,
                            PollenType = PollenTypeEnum.Sterile
                        },
                        new Variety //2
                        {
                            Name = names[1], //"Marigoule"
                            Species = sativaCrenataSpecies,
                            Description =
                                @"Marigoule is the name of a french hybrid of chestnut (synonym M.15 or CA 15), cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata). In 1986, it originated from a Migoule orchard in Ussac in Corrèze. Marigoule (a contraction of Marron of Migoule) is a very tasty chestnut. It should be planted in rather low altitude in very sunny areas and protected from the wind (up to 300 m elevation for South-West orchard orientation or up to 400 m elevation in South-East orchard orientation). Otherwise its productivity remains small. In France, it is grown mainly South of the Dordogne and Lot-et-Garonne for the fresh market production because of the nuts beautiful appearance.",
                            FruitSizes = FruitSizes
                                .Where(s => s.FruitSizeId == (int)FruitSizeTypeEnum.Large
                                    || s.FruitSizeId == (int)FruitSizeTypeEnum.XL)
                                .ToList(),
                            Images = new List<Image>
                            {
                                new Image{ FileName = "BF77FF2D-A488-4F6D-847B-3C880239A53F"}
                            },
                            Peeling = ConditionTypeEnum.Good,
                            IsMarron = true,
                            ChestnutBlightResistance = ConditionTypeEnum.Medium,
                            InkDiseaseResistance = ConditionTypeEnum.Good,
                            MaturityPeriod = PeriodTypeEnum.SemiEarly,
                            PollenType = PollenTypeEnum.Medium
                        },
                        new Variety //3
                        {
                            Name = names[2], //"Marsol",
                            Species = sativaCrenataSpecies,
                            Description =
                                @"Marsol (aka Marisol) is a natural chestnut hybrid, a cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata) (CA 07). INRA produced this variety from Lalevade-d'Ardèche. It is mainly used as a rootstock because of its good graft compatibility with many varieties. As a rootstock, it is more vigorous than Maraval (equal to Bouche de Betizac or Comballe).",
                            FruitSizes = FruitSizes
                                .Where(s => s.FruitSizeId == (int)FruitSizeTypeEnum.XL)
                                .ToList(),
                            Images = new List<Image>
                            {
                                new Image{ FileName = "EE93870C-A4AD-46F7-B5DC-F36AE12ED3A3"}
                            },
                            Peeling = ConditionTypeEnum.Good,
                            IsMarron = true,
                            ChestnutBlightResistance = ConditionTypeEnum.Good,
                            InkDiseaseResistance = ConditionTypeEnum.Good,
                            MaturityPeriod = PeriodTypeEnum.SemiEarly,
                            PollenType = PollenTypeEnum.Abundant
                        },
                        new Variety //4
                        {
                            Name = names[3], //"Précoce Migoule",
                            Species = sativaCrenataSpecies,
                            Description =
                                @"The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.",
                            FruitSizes = FruitSizes
                                .Where(s => s.FruitSizeId == (int)FruitSizeTypeEnum.Medium
                                    || s.FruitSizeId == (int)FruitSizeTypeEnum.Large)
                                .ToList(),
                            Peeling = ConditionTypeEnum.Good,
                            IsMarron = true,
                            ChestnutBlightResistance = ConditionTypeEnum.Bad,
                            InkDiseaseResistance = ConditionTypeEnum.Medium,
                            MaturityPeriod = PeriodTypeEnum.Early,
                            PollenType = PollenTypeEnum.Medium
                        },
                        new Variety { Name = "Pandora" },
                        new Variety { Name = "Nevada" },
                        new Variety { Name = "Long Street" },
                        new Variety { Name = "AU 2-18" },
                        new Variety { Name = "AU Super" },
                        new Variety { Name = "Black Satin" },
                        new Variety { Name = "Chushuhong" },
                        new Variety { Name = "Emalyn's Purple" },
                        new Variety { Name = "Gideon" },
                        new Variety { Name = "Jenny" },
                        new Variety { Name = "Jiaoza" },
                        new Variety { Name = "Payne" },
                        new Variety { Name = "Peach" },
                        new Variety { Name = "Qing" },
                        new Variety { Name = "Qingza" },
                        new Variety { Name = "Royalmark" },
                        new Variety { Name = "YGF" },
                        new Variety { Name = "Yixian Large" },
                };

                return varieties;
            }
        }

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            KestenDbContext data = applicationBuilder
                .ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<KestenDbContext>();

            data.Database.EnsureDeleted();
            data.Database.EnsureCreated();

            if (!data.Species.Any())
            {
                data.Species.AddRange(Species);
                data.SaveChanges();
            }

            if (!data.FruitSizes.Any())
            {
                data.FruitSizes.AddRange(FruitSizes);
                data.SaveChanges();
            }

            if (!data.Varieties.Any())
            {
                data.Varieties.AddRange(Varieties);
                data.SaveChanges();

                //Pollenizers
                Variety bdbId = GetVarietyIdFromName(data, names[0]);
                Variety marigouleId = GetVarietyIdFromName(data, names[1]);
                Variety marsolId = GetVarietyIdFromName(data, names[2]);
                Variety pmId = GetVarietyIdFromName(data, names[3]);

                var pollenizer = new List<VarietyPollenCompatibility>
                {
                    new VarietyPollenCompatibility
                    {
                        PollinizerVarietyId = marigouleId.VarietyId,
                        TargetVarietyId = bdbId.VarietyId
                    },
                    new VarietyPollenCompatibility
                    {
                        PollinizerVarietyId = marsolId.VarietyId,
                        TargetVarietyId = bdbId.VarietyId
                    },
                    new VarietyPollenCompatibility
                    {
                        PollinizerVarietyId = pmId.VarietyId,
                        TargetVarietyId = bdbId.VarietyId
                    }
                };
                data.VarietyPollenizers.AddRange(pollenizer);

                //Grafting
                var grafts = new List<VarietyGraftingCompatibility>
                {
                    new VarietyGraftingCompatibility
                    {
                        RootstockVarietyId = marsolId.VarietyId,
                        GraftedVarietyId = bdbId.VarietyId
                    },
                    new VarietyGraftingCompatibility
                    {
                        RootstockVarietyId = marsolId.VarietyId,
                        GraftedVarietyId = pmId.VarietyId
                    },
                    new VarietyGraftingCompatibility
                    {
                        RootstockVarietyId = marigouleId.VarietyId,
                        GraftedVarietyId = pmId.VarietyId
                    },
                };

                data.VarietyGrafting.AddRange(grafts);

                data.SaveChanges();
            }
        }

        private static Variety GetVarietyIdFromName(KestenDbContext data, string varietyName)
        {
            return data
                .Varieties
                .AsNoTracking()
                .Single(v => v.Name == varietyName);
        }
    }
}
