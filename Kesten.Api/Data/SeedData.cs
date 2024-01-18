namespace Kesten.Api.Data
{
    using Kesten.Shared.Enums;
    using Kesten.Shared.Enums.EnumHelpers;
    using Microsoft.AspNetCore.Identity;
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
        private static VarietyImage[] varietyImages = null!;
        private static IdentityRole<Guid>[] identityRoles = null!;
        private static Garden[] gardens = null!;
        private static Specimen[] specimens = null!;
        private static ApplicationUser[] applicationUsers = null!;
        private static IdentityUserRole<Guid>[] userRoles = null!;

        //used to map data
        private static DateTime dateCreated = new DateTime(2023, 7, 7, 7, 0, 0);
        private static Variety boucheDeBetizac = GetVarietyFromName("Bouche de Bétizac");
        private static Variety marigoule = GetVarietyFromName("Marigoule");
        private static Variety marsol = GetVarietyFromName("Marsol");
        private static Variety precoceMigoule = GetVarietyFromName("Précoce Migoule");
        private static Variety pandora = GetVarietyFromName("Pandora");
        private static Variety hifas = GetVarietyFromName("Hifas");

        private static Guid ownerId = Guid.Parse("09E77621-FAC4-4150-B64C-3E5C2B1A40EE");
        private static Guid expertId = Guid.Parse("8a5f6807-b43f-40fa-b836-e21874e67d51");

        public static ApplicationUser[] ApplicationUsers => GetApplicationUsers();
        public static Species[] Species => GetSpecies();
        public static Variety[] Varieties => GetVarieties();
        public static VarietySpecies[] VarietySpecies => GetVarietySpecies();
        public static FruitSize[] FruitSizes => GetFruitSizes();
        public static VarietyFruitSize[] VarietyFruitSizes => GetVarietyFruitSizes();
        public static VarietyPollenCompatibility[] VarietyPollenCompatibilities => GetVarietyPollenCompatibilities();
        public static VarietyGraftingCompatibility[] VarietyGraftingCompatibilities => GetVarietyGraftingCompatibilities();
        public static VarietyImage[] VarietyImages => GetVarietyImages();
        public static Garden[] Gardens => GetGardens();
        public static Specimen[] Specimens => GetSpecimens();
        public static IdentityRole<Guid>[] IdentityRoles => GetIdentityRoles();
        public static IdentityUserRole<Guid>[] IdentityUserRoles => GetUserRoles();

        #region Private methods
        private static IdentityUserRole<Guid>[] GetUserRoles()
        {
            if (userRoles != null)
            {
                return userRoles;
            }

            userRoles = new List<IdentityUserRole<Guid>>
            {
                new IdentityUserRole<Guid>
                {
                    RoleId = IdentityRoles.Single(r => r.Name == UserRoleType.Owner.ToString()).Id,
                    UserId = ownerId
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = IdentityRoles.Single(r => r.Name == UserRoleType.Expert.ToString()).Id,
                    UserId = expertId
                }
            }.ToArray();

            return userRoles;
        }

        private static IdentityRole<Guid>[] GetIdentityRoles()
        {
            if (identityRoles != null)
            {
                return identityRoles;
            }

            identityRoles = new IdentityRole<Guid>[]
            {
                new IdentityRole<Guid>
                {
                    Id = Guid.Parse("8E98F57D-B4FE-4E7C-B55A-96171CB3646D"),
                    Name = UserRoleType.Owner.ToString(),
                    NormalizedName = UserRoleType.Owner.ToString().ToUpper()
                },
                new IdentityRole<Guid>
                {
                    Id = Guid.Parse("E385047A-91D2-4739-87F6-9D49DA920824"),
                    Name = UserRoleType.Administrator.ToString(),
                    NormalizedName = UserRoleType.Administrator.ToString().ToUpper()
                },
                new IdentityRole<Guid>
                {
                    Id = Guid.NewGuid(),
                    Name = UserRoleType.Expert.ToString(),
                    NormalizedName = UserRoleType.Expert.ToString().ToUpper()
                },
            };

            return identityRoles;
        }

        private static ApplicationUser[] GetApplicationUsers()
        {
            if (applicationUsers != null)
            {
                return applicationUsers;
            }

            var hasher = new PasswordHasher<ApplicationUser>();
            string ownerEmail = "lubzdudz@gmail.com";
            string ownerUser = "Lyubomir D.";
            string expertEmail = "jn@chestnut.com";
            string expertUser = "JN";
            string userEmail = "user@chestnut.com";
            string userName = "Lorem Ipsum";

            applicationUsers = new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    Id = ownerId,
                    UserName = ownerUser,
                    NormalizedUserName = ownerUser.ToUpper(),
                    PasswordHash = hasher.HashPassword(null!, "123456a!"),
                    Email = ownerEmail,
                    NormalizedEmail = ownerEmail.ToUpper(),
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString()
                },
                new ApplicationUser
                {
                    Id = expertId,
                    UserName = expertUser,
                    NormalizedUserName = expertUser.ToUpper(),
                    PasswordHash = hasher.HashPassword(null!, "jn123456!"),
                    Email = expertEmail,
                    NormalizedEmail = expertEmail.ToUpper(),
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString()
                },
                new ApplicationUser
                {
                    Id = Guid.Parse("b0a8cb2c-4908-431e-a07b-f3ddd7b45bce"),
                    UserName = userName,
                    NormalizedUserName = userName.ToUpper(),
                    PasswordHash = hasher.HashPassword(null!, "temp123456!"),
                    Email = userEmail,
                    NormalizedEmail = userEmail.ToUpper(),
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString()
                }
            }.ToArray();

            return applicationUsers;
        }
        private static Specimen[] GetSpecimens()
        {
            if (specimens != null)
            {
                return specimens;
            }

            specimens = new Specimen[]
            {
                new Specimen
                {
                    SpecimenId = Guid.Parse("5ceeb8c1-9735-4c99-987e-22461216b9db"),
                    Name = "Marigoule 2019",
                    UserId = Guid.Parse("09E77621-FAC4-4150-B64C-3E5C2B1A40EE"),
                    Elevation = 642,
                    GardenId = gardens.First().GardenId,
                    PlantedOnDate = new DateTime(2019, 3, 1),
                    VarietyId = marigoule.VarietyId,
                    Row = 4,
                    Column = 2,
                },
                new Specimen
                {
                    SpecimenId = Guid.Parse("7eeeb5ea-4461-4bb4-95a6-fca45b7c69e6"),
                    Name = "Marsol 2022",
                    UserId = Guid.Parse("09E77621-FAC4-4150-B64C-3E5C2B1A40EE"),
                    Elevation = 641,
                    GardenId = gardens.First().GardenId,
                    PlantedOnDate = new DateTime(2022, 4, 1),
                    VarietyId = marsol.VarietyId,
                    Row = 4,
                    Column = 1,
                },
                new Specimen
                {
                    SpecimenId = Guid.Parse("1d4c17b8-ac58-466d-828a-90eb59fa509b"),
                    Name = "Hifas 2019",
                    UserId = Guid.Parse("09E77621-FAC4-4150-B64C-3E5C2B1A40EE"),
                    Elevation = 645,
                    GardenId = gardens.First().GardenId,
                    PlantedOnDate = new DateTime(2019, 3, 1),
                    VarietyId = hifas.VarietyId,
                    Row = 2,
                    Column = 1,
                },
            };

            return specimens;
        }

        private static Garden[] GetGardens()
        {
            if (gardens != null)
            {
                return gardens;
            }

            gardens = new Garden[]
            {
                new Garden
                {
                    GardenId = Guid.Parse("6CC4EDB7-1110-43AB-8C16-5F245EBD118C"),
                    Name = "Sharp Mound",
                    UserId = Guid.Parse("09E77621-FAC4-4150-B64C-3E5C2B1A40EE"),
                    TotalRows = 8,
                    TotalColumns = 10
                },
                new Garden
                {
                    GardenId = Guid.NewGuid(),
                    Name = "Veslets G",
                    UserId = Guid.Parse("09E77621-FAC4-4150-B64C-3E5C2B1A40EE"),
                    TotalRows = 20,
                    TotalColumns = 20
                },
            };

            return gardens;
        }

        private static Species[] GetSpecies()
        {
            if (species != null)
            {
                return species;
            }

            var tempSpecies = new List<Species>();

            foreach (SpeciesType sp in (SpeciesType[])Enum.GetValues(typeof(SpeciesType)))
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
                new Variety
                {
                    VarietyId = Guid.Parse("46BD8DC8-CA0A-4648-A9A9-EA4AD91E1B77"),
                    Name = "Bouche de Bétizac",
                    Description = @"Bouche de Bétizac is a French chestnut cultivar developed in 1962 by INRA at the station of Malemort-sur-Corrèze near Brive. It is a controlled hybrid between Castanea sativa and Castanea crenata (female Bouche rouge × male Castanea crenata CA04). This variety produces large to very large chestnuts. It has very good flavor for a hybrid. With Marigoule, it is the variety currently most cultivated in the French chestnut groves because it is very productive (3 tons per hectare on average). Its fruit is bright, light chestnut-brown quickly turning brown and dark brown.",
                    Peeling = ConditionType.Good,
                    Conservation = ConditionType.Medium,
                    Crop = VolumeType.Abundant,
                    IsMarron = true,
                    ChestnutBlightResistance = ConditionType.Good,
                    InkDiseaseResistance = ConditionType.Bad,
                    MaturityPeriod = PeriodType.Early,
                    PollenType = PollenType.Sterile,
                    Vigor = StrengthType.Medium,
                    DateCreated = dateCreated,
                },
                new Variety
                {
                    VarietyId = Guid.Parse("FBA92871-4A3C-4978-FCD6-08DB87B43C2D"),
                    Name = "Marigoule",
                    Description = @"Marigoule is the name of a french hybrid of chestnut (synonym M.15 or CA 15), cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata). In 1986, it originated from a Migoule orchard in Ussac in Corrèze. Marigoule (a contraction of Marron of Migoule) is a very tasty chestnut. It should be planted in rather low altitude in very sunny areas and protected from the wind (up to 300 m elevation for South-West orchard orientation or up to 400 m elevation in South-East orchard orientation). Otherwise its productivity remains small. In France, it is grown mainly South of the Dordogne and Lot-et-Garonne for the fresh market production because of the nuts beautiful appearance.",
                    Peeling = ConditionType.Good,
                    Conservation = ConditionType.Good,
                    IsMarron = true,
                    ChestnutBlightResistance = ConditionType.Medium,
                    InkDiseaseResistance = ConditionType.Good,
                    MaturityPeriod = PeriodType.SemiEarly,
                    PollenType = PollenType.Medium,
                    Vigor = StrengthType.Strong,
                    DateCreated = GetNextSecond()
                },
                new Variety
                {
                    VarietyId = Guid.Parse("8FC8F311-3CE9-42E2-FCD7-08DB87B43C2D"),
                    Name = "Marsol",
                    Description = @"Marsol (aka Marisol) is a natural chestnut hybrid, a cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata) (CA 07). INRA produced this variety from Lalevade-d'Ardèche. It is mainly used as a rootstock because of its good graft compatibility with many varieties. As a rootstock, it is more vigorous than Maraval (equal to Bouche de Betizac or Comballe).",
                    Peeling = ConditionType.Good,
                    Conservation = ConditionType.Good,
                    IsMarron = true,
                    ChestnutBlightResistance = ConditionType.Good,
                    InkDiseaseResistance = ConditionType.Good,
                    MaturityPeriod = PeriodType.SemiEarly,
                    PollenType = PollenType.Abundant,
                    Vigor = StrengthType.VeryStrong,
                    DateCreated = GetNextSecond()
                },
                new Variety
                {
                    VarietyId = Guid.NewGuid(),
                    Name = "Précoce Migoule",
                    Description = @"The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.",
                    Peeling = ConditionType.Good,
                    Conservation = ConditionType.Medium,
                    IsMarron = true,
                    ChestnutBlightResistance = ConditionType.Bad,
                    InkDiseaseResistance = ConditionType.Medium,
                    MaturityPeriod = PeriodType.Early,
                    PollenType = PollenType.Medium,
                    Vigor = StrengthType.Medium,
                    DateCreated = GetNextSecond()
                },
                new Variety
                {
                    VarietyId = Guid.NewGuid(),
                    Name = "Hifas",
                    Description = @"Resistant hybrid chestnut from Hifas Foresta.",
                    Peeling = ConditionType.Medium,
                    Conservation = ConditionType.Medium,
                    IsMarron = true,
                    ChestnutBlightResistance = ConditionType.Medium,
                    InkDiseaseResistance = ConditionType.Good,
                    MaturityPeriod = PeriodType.Early,
                    PollenType = PollenType.Abundant,
                    Vigor = StrengthType.VeryStrong,
                    Crop = VolumeType.Average,
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
                    SpeciesId = (int)SpeciesType.Sativa
                },
                new VarietySpecies {
                    VarietyId = boucheDeBetizac.VarietyId,
                    SpeciesId = (int)SpeciesType.Crenata
                },

                new VarietySpecies {
                    VarietyId = marigoule.VarietyId,
                    SpeciesId = (int)SpeciesType.Sativa
                },
                new VarietySpecies {
                    VarietyId = marigoule.VarietyId,
                    SpeciesId = (int)SpeciesType.Crenata
                },

                new VarietySpecies {
                    VarietyId = marsol.VarietyId,
                    SpeciesId = (int)SpeciesType.Sativa
                },
                new VarietySpecies {
                    VarietyId = marsol.VarietyId,
                    SpeciesId = (int)SpeciesType.Crenata
                },

                new VarietySpecies {
                    VarietyId = precoceMigoule.VarietyId,
                    SpeciesId = (int)SpeciesType.Sativa
                },
                new VarietySpecies {
                    VarietyId = precoceMigoule.VarietyId,
                    SpeciesId = (int)SpeciesType.Crenata
                },

                new VarietySpecies {
                    VarietyId = pandora.VarietyId,
                    SpeciesId = (int)SpeciesType.Mollissima
                },
                new VarietySpecies {
                    VarietyId = pandora.VarietyId,
                    SpeciesId = (int)SpeciesType.Seguinii
                },

                new VarietySpecies {
                    VarietyId = hifas.VarietyId,
                    SpeciesId = (int)SpeciesType.Sativa
                },
                new VarietySpecies {
                    VarietyId = hifas.VarietyId,
                    SpeciesId = (int)SpeciesType.Crenata
                },
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
            var fruitSizeEnumValues = (FruitSizeType[])Enum.GetValues(typeof(FruitSizeType));

            foreach (FruitSizeType fs in fruitSizeEnumValues)
            {
                List<RangeInt> customRanges = fs.GetAttributes<RangeInt>();
                RangeInt? fruitsPerKg = customRanges.SingleOrDefault(r => r.Type == IntRangeType.FruitsPerKg);
                RangeInt? fruitWeight = customRanges.SingleOrDefault(r => r.Type == IntRangeType.FruitWeight);

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
                    FruitSizeId = (int)FruitSizeType.XL,
                    VarietyId = boucheDeBetizac.VarietyId
                },
                new VarietyFruitSize {
                    FruitSizeId = (int)FruitSizeType.Large,
                    VarietyId = marigoule.VarietyId
                },
                new VarietyFruitSize {
                    FruitSizeId = (int)FruitSizeType.XL,
                    VarietyId = marigoule.VarietyId
                },
                new VarietyFruitSize {
                    FruitSizeId = (int)FruitSizeType.XL,
                    VarietyId = marsol.VarietyId
                },
                new VarietyFruitSize {
                    FruitSizeId = (int)FruitSizeType.Medium,
                    VarietyId = precoceMigoule.VarietyId
                },
                new VarietyFruitSize {
                    FruitSizeId = (int)FruitSizeType.Large,
                    VarietyId = precoceMigoule.VarietyId
                },
                new VarietyFruitSize {
                    FruitSizeId = (int)FruitSizeType.Large,
                    VarietyId = hifas.VarietyId
                },
                new VarietyFruitSize {
                    FruitSizeId = (int)FruitSizeType.XL,
                    VarietyId = hifas.VarietyId
                },
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

        private static VarietyImage[] GetVarietyImages()
        {
            if (varietyImages != null)
            {
                return varietyImages;
            }

            varietyImages = new VarietyImage[]{
                new VarietyImage {
                    ImageId = Guid.Parse("BE9CCA3D-4E9A-4E75-B813-9279F79F7F75"),
                    VarietyId = boucheDeBetizac.VarietyId,
                },
                new VarietyImage {
                    ImageId = Guid.Parse("BF77FF2D-A488-4F6D-847B-3C880239A53F"),
                    VarietyId = marigoule.VarietyId
                },
                new VarietyImage {
                    ImageId = Guid.Parse("EE93870C-A4AD-46F7-B5DC-F36AE12ED3A3"),
                    VarietyId = marsol.VarietyId
                },
            };

            return varietyImages;
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
        #endregion
    }
}
