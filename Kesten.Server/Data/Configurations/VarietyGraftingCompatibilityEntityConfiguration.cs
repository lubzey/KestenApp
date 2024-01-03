namespace Kesten.Server.Data.Configurations
{
    using Kesten.Server.Data;
    using Kesten.Server.Data.Models;
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

            builder.HasData(SeedData.VarietyGraftingCompatibilities);
        }
    }
}
