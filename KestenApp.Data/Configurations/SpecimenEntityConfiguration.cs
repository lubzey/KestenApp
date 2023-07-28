namespace KestenApp.Data.Configurations
{
    using KestenApp.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class SpecimenEntityConfiguration : IEntityTypeConfiguration<Specimen>
    {
        public void Configure(EntityTypeBuilder<Specimen> builder)
        {
            builder
               .Property(v => v.DateCreated)
               .HasDefaultValueSql("GETDATE()");

            builder
                .HasOne(v => v.Variety)
                .WithMany(v => v.Specimens)
                .HasForeignKey(e => e.VarietyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(v => v.Garden)
                .WithMany(v => v.Specimens)
                .HasForeignKey(e => e.GardenId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .ToTable("Specimens");

            builder.HasData(SeedData.Specimens);
        }
    }
}
