namespace Kesten.Api.Data.Configurations
{
    using Kesten.Api.Data;
    using Kesten.Api.Data.Models;
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

            builder.HasData(SeedData.VarietyPollenCompatibilities);
        }
    }
}
