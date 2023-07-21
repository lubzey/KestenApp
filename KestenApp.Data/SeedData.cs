﻿namespace KestenApp.Data
{
    using Enums;
    using Enums.EnumHelpers;
    using Models;

    public static class SeedData
    {
        private static Species[] species = null!;
        private static Variety[] varieties = null!;
        private static VarietySpecies[] varietySpecies = null!;
        private static FruitSize[] fruitSizes = null!;
        private static VarietyFruitSize[] varietyfruitSizes = null!;
        private static VarietyPollenCompatibility[] varietyPollenCompatibilities = null!;
        private static VarietyGraftingCompatibility[] varietyGraftingCompatibilities = null!;

        //used to map data
        private static DateTime dateCreated = new DateTime(2023, 7, 7, 7, 0, 0);
        private static Variety boucheDeBetizac = GetVarietyFromName("Bouche de Bétizac");
        private static Variety marigoule = GetVarietyFromName("Marigoule");
        private static Variety marsol = GetVarietyFromName("Marsol");
        private static Variety precoceMigoule = GetVarietyFromName("Précoce Migoule");
        private static Variety pandora = GetVarietyFromName("Pandora");

        public static Species[] Species { get { return GetSpecies(); } }
        public static Variety[] Varieties { get { return GetVarieties(); } }
        public static VarietySpecies[] VarietySpecies { get { return GetVarietySpecies(); } }
        public static FruitSize[] FruitSizes { get { return GetFruitSizes(); } }
        public static VarietyFruitSize[] VarietyFruitSizes { get { return GetVarietyFruitSizes(); } }
        public static VarietyPollenCompatibility[] VarietyPollenCompatibilities { get { return GetVarietyPollenCompatibilities(); } }
        public static VarietyGraftingCompatibility[] VarietyGraftingCompatibilities { get { return GetVarietyGraftingCompatibilities(); } }

        private static Species[] GetSpecies()
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
                        SpeciesId = (int)sp,
                        CommonName = sp.GetDescription() ?? string.Empty,
                        LatinName = sp.GetDisplayName() ?? sp.ToString(),
                        ShortLatinName = sp.ToString(),
                    });
            }

            species = tempSpecies.ToArray();

            return species;
        }

        private static Variety[] GetVarieties()
        {
            if (varieties != null)
            {
                return varieties;
            }

            varieties = new Variety[]
            {
                new Variety //1
                {
                    VarietyId = new Guid("46BD8DC8-CA0A-4648-A9A9-EA4AD91E1B77"),
                    Name = "Bouche de Bétizac",
                    Description = @"Bouche de Bétizac is a French chestnut cultivar developed in 1962 by INRA at the station of Malemort-sur-Corrèze near Brive. It is a controlled hybrid between Castanea sativa and Castanea crenata (female Bouche rouge × male Castanea crenata CA04). This variety produces large to very large chestnuts. It has very good flavor for a hybrid. With Marigoule, it is the variety currently most cultivated in the French chestnut groves because it is very productive (3 tons per hectare on average). Its fruit is bright, light chestnut-brown quickly turning brown and dark brown.",
                    Peeling = ConditionTypeEnum.Good,
                    IsMarron = true,
                    ChestnutBlightResistance = ConditionTypeEnum.Good,
                    InkDiseaseResistance = ConditionTypeEnum.Bad,
                    MaturityPeriod = PeriodTypeEnum.Early,
                    PollenType = PollenTypeEnum.Sterile,
                    DateCreated = dateCreated
                },
                new Variety //2
                {
                    VarietyId = Guid.NewGuid(),
                    Name = "Marigoule",
                    Description = @"Marigoule is the name of a french hybrid of chestnut (synonym M.15 or CA 15), cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata). In 1986, it originated from a Migoule orchard in Ussac in Corrèze. Marigoule (a contraction of Marron of Migoule) is a very tasty chestnut. It should be planted in rather low altitude in very sunny areas and protected from the wind (up to 300 m elevation for South-West orchard orientation or up to 400 m elevation in South-East orchard orientation). Otherwise its productivity remains small. In France, it is grown mainly South of the Dordogne and Lot-et-Garonne for the fresh market production because of the nuts beautiful appearance.",
                    Peeling = ConditionTypeEnum.Good,
                    IsMarron = true,
                    ChestnutBlightResistance = ConditionTypeEnum.Medium,
                    InkDiseaseResistance = ConditionTypeEnum.Good,
                    MaturityPeriod = PeriodTypeEnum.SemiEarly,
                    PollenType = PollenTypeEnum.Medium,
                    DateCreated = GetNextSecond()
                },
                new Variety //3
                {
                    VarietyId = Guid.NewGuid(),
                    Name = "Marsol",
                    Description = @"Marsol (aka Marisol) is a natural chestnut hybrid, a cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata) (CA 07). INRA produced this variety from Lalevade-d'Ardèche. It is mainly used as a rootstock because of its good graft compatibility with many varieties. As a rootstock, it is more vigorous than Maraval (equal to Bouche de Betizac or Comballe).",
                    Peeling = ConditionTypeEnum.Good,
                    IsMarron = true,
                    ChestnutBlightResistance = ConditionTypeEnum.Good,
                    InkDiseaseResistance = ConditionTypeEnum.Good,
                    MaturityPeriod = PeriodTypeEnum.SemiEarly,
                    PollenType = PollenTypeEnum.Abundant,
                    DateCreated = GetNextSecond()
                },
                new Variety //4
                {
                    VarietyId = Guid.NewGuid(),
                    Name = "Précoce Migoule",
                    Description = @"The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.",
                    Peeling = ConditionTypeEnum.Good,
                    IsMarron = true,
                    ChestnutBlightResistance = ConditionTypeEnum.Bad,
                    InkDiseaseResistance = ConditionTypeEnum.Medium,
                    MaturityPeriod = PeriodTypeEnum.Early,
                    PollenType = PollenTypeEnum.Medium,
                    DateCreated = GetNextSecond()
                },
                new Variety { VarietyId = Guid.NewGuid(), Name = "Pandora", DateCreated = GetNextSecond() },
                new Variety { VarietyId = Guid.NewGuid(), Name = "Nevada", DateCreated = GetNextSecond() },
                new Variety { VarietyId = Guid.NewGuid(), Name = "Long Street", DateCreated = GetNextSecond() },
                new Variety { VarietyId = Guid.NewGuid(), Name = "AU 2-18", DateCreated = GetNextSecond() },
                new Variety { VarietyId = Guid.NewGuid(), Name = "AU Super", DateCreated = GetNextSecond() },
                new Variety { VarietyId = Guid.NewGuid(), Name = "Black Satin", DateCreated = GetNextSecond() },
                new Variety { VarietyId = Guid.NewGuid(), Name = "Chushuhong", DateCreated = GetNextSecond() },
                new Variety { VarietyId = Guid.NewGuid(), Name = "Emalyn's Purple", DateCreated = GetNextSecond() },
                new Variety { VarietyId = Guid.NewGuid(), Name = "Gideon", DateCreated = GetNextSecond() },
                new Variety { VarietyId = Guid.NewGuid(), Name = "Jenny", DateCreated = GetNextSecond() },
                new Variety { VarietyId = Guid.NewGuid(), Name = "Jiaoza", DateCreated = GetNextSecond() },
                new Variety { VarietyId = Guid.NewGuid(), Name = "Payne", DateCreated = GetNextSecond() },
                new Variety { VarietyId = Guid.NewGuid(), Name = "Peach", DateCreated = GetNextSecond() },
                new Variety { VarietyId = Guid.NewGuid(), Name = "Qing", DateCreated = GetNextSecond() },
                new Variety { VarietyId = Guid.NewGuid(), Name = "Qingza", DateCreated = GetNextSecond() },
                new Variety { VarietyId = Guid.NewGuid(), Name = "Royalmark", DateCreated = GetNextSecond() },
                new Variety { VarietyId = Guid.NewGuid(), Name = "YGF", DateCreated = GetNextSecond() },
                new Variety { VarietyId = Guid.NewGuid(), Name = "Yixian Large" },
            };

            return varieties;
        }

        private static VarietySpecies[] GetVarietySpecies()
        {
            if (varietySpecies != null)
            {
                return varietySpecies;
            }

            varietySpecies = new VarietySpecies[]
            {
                new VarietySpecies {
                    VarietyId = boucheDeBetizac.VarietyId,
                    SpeciesId = (int)SpeciesTypeEnum.Sativa
                },
                new VarietySpecies {
                    VarietyId = boucheDeBetizac.VarietyId,
                    SpeciesId = (int)SpeciesTypeEnum.Crenata
                },

                new VarietySpecies {
                    VarietyId = marigoule.VarietyId,
                    SpeciesId = (int)SpeciesTypeEnum.Sativa
                },
                new VarietySpecies {
                    VarietyId = marigoule.VarietyId,
                    SpeciesId = (int)SpeciesTypeEnum.Crenata
                },

                new VarietySpecies {
                    VarietyId = marsol.VarietyId,
                    SpeciesId = (int)SpeciesTypeEnum.Sativa
                },
                new VarietySpecies {
                    VarietyId = marsol.VarietyId,
                    SpeciesId = (int)SpeciesTypeEnum.Crenata
                },

                new VarietySpecies {
                    VarietyId = precoceMigoule.VarietyId,
                    SpeciesId = (int)SpeciesTypeEnum.Sativa
                },
                new VarietySpecies {
                    VarietyId = precoceMigoule.VarietyId,
                    SpeciesId = (int)SpeciesTypeEnum.Crenata
                },

                //Pandora
                new VarietySpecies {
                    VarietyId = pandora.VarietyId,
                    SpeciesId = (int)SpeciesTypeEnum.Mollissima
                },
                new VarietySpecies {
                    VarietyId = pandora.VarietyId,
                    SpeciesId = (int)SpeciesTypeEnum.Seguinii
                }
            };

            return varietySpecies;
        }

        private static FruitSize[] GetFruitSizes()
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
                        FruitSizeId = (int)fs,
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

        private static VarietyFruitSize[] GetVarietyFruitSizes()
        {
            if (varietyfruitSizes != null)
            {
                return varietyfruitSizes;
            }

            varietyfruitSizes = new VarietyFruitSize[]{
                new VarietyFruitSize {
                    FruitSizeId = (int)FruitSizeTypeEnum.XL,
                    VarietyId = boucheDeBetizac.VarietyId
                },
                new VarietyFruitSize {
                    FruitSizeId = (int)FruitSizeTypeEnum.Large,
                    VarietyId = marigoule.VarietyId
                },
                new VarietyFruitSize {
                    FruitSizeId = (int)FruitSizeTypeEnum.XL,
                    VarietyId = marigoule.VarietyId
                },
                new VarietyFruitSize {
                    FruitSizeId = (int)FruitSizeTypeEnum.XL,
                    VarietyId = marsol.VarietyId
                },
                new VarietyFruitSize {
                    FruitSizeId = (int)FruitSizeTypeEnum.Medium,
                    VarietyId = precoceMigoule.VarietyId
                },
                new VarietyFruitSize {
                    FruitSizeId = (int)FruitSizeTypeEnum.Large,
                    VarietyId = precoceMigoule.VarietyId
                }
            };

            return varietyfruitSizes;
        }

        private static VarietyPollenCompatibility[] GetVarietyPollenCompatibilities()
        {
            if (varietyPollenCompatibilities != null)
            {
                return varietyPollenCompatibilities;
            }

            varietyPollenCompatibilities = new VarietyPollenCompatibility[]{
                new VarietyPollenCompatibility {
                    TargetVarietyId = boucheDeBetizac.VarietyId,
                    PollenizerVarietyId = marigoule.VarietyId
                },
                new VarietyPollenCompatibility {
                    TargetVarietyId = boucheDeBetizac.VarietyId,
                    PollenizerVarietyId = marsol.VarietyId
                },
                new VarietyPollenCompatibility {
                    TargetVarietyId = boucheDeBetizac.VarietyId,
                    PollenizerVarietyId = precoceMigoule.VarietyId
                },
            };

            return varietyPollenCompatibilities;
        }

        private static VarietyGraftingCompatibility[] GetVarietyGraftingCompatibilities()
        {
            if (varietyGraftingCompatibilities != null)
            {
                return varietyGraftingCompatibilities;
            }

            varietyGraftingCompatibilities = new VarietyGraftingCompatibility[]{
                new VarietyGraftingCompatibility {
                    GraftedVarietyId = boucheDeBetizac.VarietyId,
                    RootstockVarietyId = marsol.VarietyId
                },
                new VarietyGraftingCompatibility {
                    GraftedVarietyId = precoceMigoule.VarietyId,
                    RootstockVarietyId = marsol.VarietyId
                },
                new VarietyGraftingCompatibility {
                    GraftedVarietyId = precoceMigoule.VarietyId,
                    RootstockVarietyId = marigoule.VarietyId
                },
            };

            return varietyGraftingCompatibilities;
        }

        //Helper methods
        private static Variety GetVarietyFromName(string varietyName)
        {
            //Used to get specific varieties instead of getting them by index
            return Varieties
                .Single(v => v.Name == varietyName);
        }

        private static DateTime GetNextSecond()
        {
            //Used to keep variety records in some order
            dateCreated = dateCreated.AddSeconds(1);

            return dateCreated;
        }
    }
}
