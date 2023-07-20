namespace KestenApp.Data.Configurations
{
    using KestenApp.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class VarietyGraftingCompatibilityEntityConfiguration : IEntityTypeConfiguration<VarietyGraftingCompatibility>
    {
        public void Configure(EntityTypeBuilder<VarietyGraftingCompatibility> builder)
        {
            builder
                .HasOne(ub => ub.RootstockVariety)
                .WithMany(x => x.IsRootstockFor)
                .HasForeignKey(h => h.RootstockVarietyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(ub => ub.GraftedVariety)
                .WithMany(x => x.IsGraftedOn)
                .HasForeignKey(h => h.GraftedVarietyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasKey(gu => new { gu.RootstockVarietyId, gu.GraftedVarietyId });

            builder
                .ToTable("VarietyGrafting");

            //builder.HasData(this.GenerateVarietyPollenCompatibilities());
        }

        //private VarietyGraftingCompatibility[] GenerateVarietyPollenCompatibilities()
        //{
        //    //Pollenizers
        //    Variety bdbId = GetVarietyFromName("Bouche de Bétizac");
        //    Variety marigoule = GetVarietyFromName("Marigoule");
        //    Variety marsol = GetVarietyFromName("Marsol");
        //    Variety pmId = GetVarietyFromName("Précoce Migoule");

        //    return new VarietyGraftingCompatibility[]
        //    {
        //        new VarietyGraftingCompatibility
        //        {
        //            RootstockVarietyId = marsol.VarietyId,
        //            GraftedVarietyId = bdbId.VarietyId
        //        },
        //        new VarietyGraftingCompatibility
        //        {
        //            RootstockVarietyId = marsol.VarietyId,
        //            GraftedVarietyId = pmId.VarietyId
        //        },
        //        new VarietyGraftingCompatibility
        //        {
        //            RootstockVarietyId = marigoule.VarietyId,
        //            GraftedVarietyId = pmId.VarietyId
        //        },
        //    };
        //}

        //private Variety GetVarietyFromName(string varietyName)
        //{
        //    return dbContext
        //        .Varieties
        //        .AsNoTracking()
        //        .Single(v => v.Name == varietyName);
        //}
    }
}
