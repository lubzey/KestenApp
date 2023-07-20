namespace KestenApp.Data
{
    using Enums;
    using Enums.EnumHelpers;
    using Microsoft.IdentityModel.Tokens;
    using Models;

    public static class SeedData
    {
        private static Variety[] varieties = null!;
        private static ICollection<FruitSize> fruitSizes = null!;

        public static Variety[] Varieties { get { return GetVarieties(); } }
        public static ICollection<FruitSize> FruitSizes { get { return GetFruitSizes(); } }

        private static Variety[] GetVarieties()
        {
            var varieties = new Variety[]
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
                    PollenType = PollenTypeEnum.Sterile
                },
                new Variety //2
                {
                    Name = "Marigoule",
                    Description = @"Marigoule is the name of a french hybrid of chestnut (synonym M.15 or CA 15), cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata). In 1986, it originated from a Migoule orchard in Ussac in Corrèze. Marigoule (a contraction of Marron of Migoule) is a very tasty chestnut. It should be planted in rather low altitude in very sunny areas and protected from the wind (up to 300 m elevation for South-West orchard orientation or up to 400 m elevation in South-East orchard orientation). Otherwise its productivity remains small. In France, it is grown mainly South of the Dordogne and Lot-et-Garonne for the fresh market production because of the nuts beautiful appearance.",
                    Peeling = ConditionTypeEnum.Good,
                    IsMarron = true,
                    ChestnutBlightResistance = ConditionTypeEnum.Medium,
                    InkDiseaseResistance = ConditionTypeEnum.Good,
                    MaturityPeriod = PeriodTypeEnum.SemiEarly,
                    PollenType = PollenTypeEnum.Medium
                },
                new Variety //3
                {
                    Name = "Marsol",
                    Description = @"Marsol (aka Marisol) is a natural chestnut hybrid, a cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata) (CA 07). INRA produced this variety from Lalevade-d'Ardèche. It is mainly used as a rootstock because of its good graft compatibility with many varieties. As a rootstock, it is more vigorous than Maraval (equal to Bouche de Betizac or Comballe).",
                    Peeling = ConditionTypeEnum.Good,
                    IsMarron = true,
                    ChestnutBlightResistance = ConditionTypeEnum.Good,
                    InkDiseaseResistance = ConditionTypeEnum.Good,
                    MaturityPeriod = PeriodTypeEnum.SemiEarly,
                    PollenType = PollenTypeEnum.Abundant
                },
                new Variety //4
                {
                    Name = "Précoce Migoule",
                    Description = @"The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.",
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

        private static ICollection<FruitSize> GetFruitSizes()
        {
            if (fruitSizes != null)
            {
                return fruitSizes;
            }

            fruitSizes = new List<FruitSize>();
            var fruitSizeEnumValues = (FruitSizeTypeEnum[])Enum.GetValues(typeof(FruitSizeTypeEnum));

            foreach (FruitSizeTypeEnum fs in fruitSizeEnumValues)
            {
                List<RangeInt> customRanges = fs.GetAttributes<RangeInt>();
                RangeInt? fruitsPerKg = customRanges.SingleOrDefault(r => r.Type == IntRangeTypeEnum.FruitsPerKg);
                RangeInt? fruitWeight = customRanges.SingleOrDefault(r => r.Type == IntRangeTypeEnum.FruitWeight);

                fruitSizes.Add(
                    new FruitSize
                    {
                        Name = fs.ToString(),
                        FruitsPerKgMin = fruitsPerKg?.Minimun,
                        FruitsPerKgMax = fruitsPerKg?.Maximum,
                        FruitsWeightMin = fruitWeight?.Minimun,
                        FruitsWeightMax = fruitWeight?.Maximum,
                    });
            }

            return fruitSizes
                .OrderBy(fs => fs.FruitSizeId)
                .ToArray(); ;
        }

        private static ICollection<VarietyFruitSize> GenerateVarietyFruitSizes()
        {
            return new VarietyFruitSize[]{
                new VarietyFruitSize {
                    FruitSizeId = 1,
                    VarietyId = varieties[0].VarietyId,
                    VarietyFruitSizeId = (int)FruitSizeTypeEnum.XL
                },
                new VarietyFruitSize {
                    FruitSizeId = 2,
                    VarietyId = Guid.Parse("46BD8DC8-CA0A-4648-A9A9-EA4AD91E1B77"),
                    VarietyFruitSizeId = (int)FruitSizeTypeEnum.Large
                }
            };
        }
    }
}
