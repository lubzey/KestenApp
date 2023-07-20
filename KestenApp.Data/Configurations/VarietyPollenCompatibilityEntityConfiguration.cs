namespace KestenApp.Data.Configurations
{
    using KestenApp.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class VarietyPollenCompatibilityEntityConfiguration : IEntityTypeConfiguration<VarietyPollenCompatibility>
    {
        //private KestenDbContext dbContext;

        public VarietyPollenCompatibilityEntityConfiguration()//KestenDbContext dbContext)
        {
            //this.dbContext = dbContext;
        }

        public void Configure(EntityTypeBuilder<VarietyPollenCompatibility> builder)
        {
            builder
                .HasOne(ub => ub.TargetVariety)
                .WithMany(x => x.IsPollenizedBy)
                .HasForeignKey(h => h.TargetVarietyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(ub => ub.PollenizerVariety)
                .WithMany(x => x.IsPollenizerFor)
                .HasForeignKey(h => h.PollenizerVarietyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasKey(gu => new { gu.PollenizerVarietyId, gu.TargetVarietyId });

            builder
                .ToTable("VarietyPollenizers");

            //builder.HasData(this.GenerateVarietyPollenCompatibilities());
        }

        //private VarietyPollenCompatibility[] GenerateVarietyPollenCompatibilities()
        //{
        //    //Pollenizers
        //    Variety bdbId = GetVarietyFromName("Bouche de Bétizac");
        //    Variety marigoule = GetVarietyFromName("Marigoule");
        //    Variety marsol = GetVarietyFromName("Marsol");
        //    Variety pmId = GetVarietyFromName("Précoce Migoule");

        //    return new VarietyPollenCompatibility[]
        //    {
        //        new VarietyPollenCompatibility
        //        {
        //            PollenizerVariety = marigoule,
        //            TargetVariety = bdbId
        //        },
        //        new VarietyPollenCompatibility
        //        {
        //            PollenizerVarietyId = marsol.VarietyId,
        //            TargetVarietyId = bdbId.VarietyId
        //        },
        //        new VarietyPollenCompatibility
        //        {
        //            PollenizerVarietyId = pmId.VarietyId,
        //            TargetVarietyId = bdbId.VarietyId
        //        }
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
