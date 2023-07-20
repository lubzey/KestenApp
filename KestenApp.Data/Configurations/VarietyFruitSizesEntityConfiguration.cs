namespace KestenApp.Data.Configurations
{
    using KestenApp.Data.Enums;
    using KestenApp.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class VarietyFruitSizesEntityConfiguration : IEntityTypeConfiguration<VarietyFruitSize>
    {
        public void Configure(EntityTypeBuilder<VarietyFruitSize> builder)
        {
            builder
                .HasOne(e => e.Variety)
                .WithMany(e => e.FruitSizes)
                .HasForeignKey(x => x.VarietyId);

            builder
                .HasOne(e => e.FruitSize)
                .WithMany(e => e.Varieties)
                .HasForeignKey(x => x.FruitSizeId);

            builder.HasData(this.GenerateVarietyFruitSizes());
        }

        private VarietyFruitSize[] GenerateVarietyFruitSizes()
        {
            return new VarietyFruitSize[]{
                new VarietyFruitSize {
                    FruitSizeId = 1,
                    VarietyId = Guid.Parse("46BD8DC8-CA0A-4648-A9A9-EA4AD91E1B77"),
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
