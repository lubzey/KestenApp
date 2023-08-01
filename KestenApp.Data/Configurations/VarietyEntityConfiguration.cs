namespace KestenApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using KestenApp.Data.Models;

    public class VarietyEntityConfiguration : IEntityTypeConfiguration<Variety>
    {
        public void Configure(EntityTypeBuilder<Variety> builder)
        {
            builder
               .Property(v => v.DateCreated)
               .HasDefaultValueSql("GETDATE()");

            builder
                .HasMany(v => v.VarietyImages)
                .WithOne(v => v.Variety)
                .HasForeignKey(e => e.ImageId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(v => v.Specimens)
                .WithOne(s => s.Variety)
                .HasForeignKey(e => e.VarietyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .ToTable("Varieties");

            builder.HasData(SeedData.Varieties);
        }
    }
}
