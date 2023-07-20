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
                .HasMany(e => e.Images)
                .WithMany(e => e.Varieties)
                .UsingEntity("VarietyImages");

            builder
                .ToTable("Varieties");

            builder.HasData(SeedData.Varieties);
        }
    }
}
