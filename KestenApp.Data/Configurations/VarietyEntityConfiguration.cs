namespace KestenApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using KestenApp.Data.Enums;
    using Models;

    public class VarietyEntityConfiguration : IEntityTypeConfiguration<Variety>
    {
        //private KestenDbContext dbContext;

        public VarietyEntityConfiguration()//(KestenDbContext dbContext)
        {
            //this.dbContext = dbContext;
        }

        public void Configure(EntityTypeBuilder<Variety> builder)
        {
            //Default value
            builder
               .Property(v => v.DateCreated)
               .HasDefaultValueSql("GETDATE()");

            //todo:Remove additional tables and stick with enums
            //builder
            //    .HasMany(e => e.Species)
            //    .WithMany(e => e.Varieties)
            //    .UsingEntity("VarietySpecies");

            //builder
            //    .HasMany(e => e.FruitSizes)
            //    .WithMany(e => e.Varieties)
            //    .UsingEntity("VarietyFruitSizes");

            builder
                .HasMany(e => e.Images)
                .WithMany(e => e.Varieties)
                .UsingEntity("VarietyImages");

            //Table name
            builder
                .ToTable("Varieties");

            builder.HasData(this.GenerateVarieties());
        }

        private Variety[] GenerateVarieties()
        {
            //var sativaCrenataSpecies = dbContext
            //    .Species
            //    .Where(s => (SpeciesTypeEnum)s.SpeciesId == SpeciesTypeEnum.Sativa
            //        || (SpeciesTypeEnum)s.SpeciesId == SpeciesTypeEnum.Crenata)
            //    .ToList();

            return new Variety[]
                {
                    new Variety //1
                    {
                        VarietyId = Guid.Parse("46BD8DC8-CA0A-4648-A9A9-EA4AD91E1B77"),
                        Name = "Bouche de Bétizac",
                        //Species = new List<Species>{
                        //    new Species { SpeciesId = (int)SpeciesTypeEnum.Sativa },
                        //    new Species { SpeciesId = (int)SpeciesTypeEnum.Crenata }
                        //},
                        Description =
                            @"Bouche de Bétizac is a French chestnut cultivar developed in 1962 by INRA at the station of Malemort-sur-Corrèze near Brive. It is a controlled hybrid between Castanea sativa and Castanea crenata (female Bouche rouge × male Castanea crenata CA04). This variety produces large to very large chestnuts. It has very good flavor for a hybrid. With Marigoule, it is the variety currently most cultivated in the French chestnut groves because it is very productive (3 tons per hectare on average). Its fruit is bright, light chestnut-brown quickly turning brown and dark brown.",
                        //FruitSizes = new List<FruitSize>
                        //{
                        //    new FruitSize { FruitSizeId = (int)FruitSizeTypeEnum.XL}
                        //},
                        //Images = new List<Image>
                        //{
                        //    new Image{ FileName = "BE9CCA3D-4E9A-4E75-B813-9279F79F7F75"}
                        //},
                        Peeling = ConditionTypeEnum.Good,
                        IsMarron = true,
                        ChestnutBlightResistance = ConditionTypeEnum.Good,
                        InkDiseaseResistance = ConditionTypeEnum.Bad,
                        MaturityPeriod = PeriodTypeEnum.Early,
                        PollenType = PollenTypeEnum.Sterile
                    },
                    //new Variety //2
                    //{
                    //    Name = "Marigoule",
                    //    Species = sativaCrenataSpecies,
                    //    Description =
                    //        @"Marigoule is the name of a french hybrid of chestnut (synonym M.15 or CA 15), cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata). In 1986, it originated from a Migoule orchard in Ussac in Corrèze. Marigoule (a contraction of Marron of Migoule) is a very tasty chestnut. It should be planted in rather low altitude in very sunny areas and protected from the wind (up to 300 m elevation for South-West orchard orientation or up to 400 m elevation in South-East orchard orientation). Otherwise its productivity remains small. In France, it is grown mainly South of the Dordogne and Lot-et-Garonne for the fresh market production because of the nuts beautiful appearance.",
                    //    FruitSizes = dbContext
                    //        .FruitSizes
                    //        .Where(s => s.FruitSizeId == (int)FruitSizeTypeEnum.Large
                    //            || s.FruitSizeId == (int)FruitSizeTypeEnum.XL)
                    //        .ToList(),
                    //    Images = new List<Image>
                    //    {
                    //        new Image{ FileName = "BF77FF2D-A488-4F6D-847B-3C880239A53F"}
                    //    },
                    //    Peeling = ConditionTypeEnum.Good,
                    //    IsMarron = true,
                    //    ChestnutBlightResistance = ConditionTypeEnum.Medium,
                    //    InkDiseaseResistance = ConditionTypeEnum.Good,
                    //    MaturityPeriod = PeriodTypeEnum.SemiEarly,
                    //    PollenType = PollenTypeEnum.Medium
                    //},
                    //new Variety //3
                    //{
                    //    Name = "Marsol",
                    //    Species = sativaCrenataSpecies,
                    //    Description =
                    //        @"Marsol (aka Marisol) is a natural chestnut hybrid, a cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata) (CA 07). INRA produced this variety from Lalevade-d'Ardèche. It is mainly used as a rootstock because of its good graft compatibility with many varieties. As a rootstock, it is more vigorous than Maraval (equal to Bouche de Betizac or Comballe).",
                    //    FruitSizes = dbContext
                    //        .FruitSizes
                    //        .Where(s => s.FruitSizeId == (int)FruitSizeTypeEnum.XL)
                    //        .ToList(),
                    //    Images = new List<Image>
                    //    {
                    //        new Image{ FileName = "EE93870C-A4AD-46F7-B5DC-F36AE12ED3A3"}
                    //    },
                    //    Peeling = ConditionTypeEnum.Good,
                    //    IsMarron = true,
                    //    ChestnutBlightResistance = ConditionTypeEnum.Good,
                    //    InkDiseaseResistance = ConditionTypeEnum.Good,
                    //    MaturityPeriod = PeriodTypeEnum.SemiEarly,
                    //    PollenType = PollenTypeEnum.Abundant
                    //},
                    //new Variety //4
                    //{
                    //    Name = "Précoce Migoule",
                    //    Species = sativaCrenataSpecies,
                    //    Description =
                    //        @"The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.",
                    //    FruitSizes = dbContext
                    //        .FruitSizes
                    //        .Where(s => s.FruitSizeId == (int)FruitSizeTypeEnum.Medium
                    //            || s.FruitSizeId == (int)FruitSizeTypeEnum.Large)
                    //        .ToList(),
                    //    Peeling = ConditionTypeEnum.Good,
                    //    IsMarron = true,
                    //    ChestnutBlightResistance = ConditionTypeEnum.Bad,
                    //    InkDiseaseResistance = ConditionTypeEnum.Medium,
                    //    MaturityPeriod = PeriodTypeEnum.Early,
                    //    PollenType = PollenTypeEnum.Medium
                    //},
                    new Variety { VarietyId = Guid.NewGuid(), Name = "Pandora" },
                    new Variety { VarietyId = Guid.NewGuid(), Name = "Nevada" },
                    new Variety { VarietyId = Guid.NewGuid(), Name = "Long Street" },
                    new Variety { VarietyId = Guid.NewGuid(), Name = "AU 2-18" },
                    new Variety { VarietyId = Guid.NewGuid(), Name = "AU Super" },
                    new Variety { VarietyId = Guid.NewGuid(), Name = "Black Satin" },
                    new Variety { VarietyId = Guid.NewGuid(), Name = "Chushuhong" },
                    new Variety { VarietyId = Guid.NewGuid(), Name = "Emalyn's Purple" },
                    new Variety { VarietyId = Guid.NewGuid(), Name = "Gideon" },
                    new Variety { VarietyId = Guid.NewGuid(), Name = "Jenny" },
                    new Variety { VarietyId = Guid.NewGuid(), Name = "Jiaoza" },
                    new Variety { VarietyId = Guid.NewGuid(), Name = "Payne" },
                    new Variety { VarietyId = Guid.NewGuid(), Name = "Peach" },
                    new Variety { VarietyId = Guid.NewGuid(), Name = "Qing" },
                    new Variety { VarietyId = Guid.NewGuid(), Name = "Qingza" },
                    new Variety { VarietyId = Guid.NewGuid(), Name = "Royalmark" },
                    new Variety { VarietyId = Guid.NewGuid(), Name = "YGF" },
                    new Variety { VarietyId = Guid.NewGuid(), Name = "Yixian Large" },
                };
        }
    }
}
