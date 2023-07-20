namespace KestenApp.Data
{
    using System.Reflection;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Models;

    public class KestenDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public DbSet<Variety> Varieties { get; set; } = null!;
        public DbSet<Species> Species { get; set; } = null!;
        public DbSet<Garden> Gardens { get; set; } = null!;
        public DbSet<Specimen> Specimens { get; set; } = null!;

        //Varieties
        public DbSet<FruitSize> FruitSizes { get; set; } = null!;
        public DbSet<VarietyPollenCompatibility> VarietyPollenizers { get; set; } = null!;
        public DbSet<VarietyGraftingCompatibility> VarietyGrafting { get; set; } = null!;
        public DbSet<Image> Images { get; set; } = null!;

        //Test
        public DbSet<VarietySpecies> VarietySpecies { get; set; } = null!;

        public KestenDbContext(DbContextOptions<KestenDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(KestenDbContext)) ??
                                      Assembly.GetExecutingAssembly();
            builder.ApplyConfigurationsFromAssembly(configAssembly);

            //Needed for Identity
            base.OnModelCreating(builder);

            ////Default value
            //modelBuilder.Entity<Variety>()
            //   .Property(v => v.DateCreated)
            //   .HasDefaultValueSql("getdate()");

            ////todo:Remove additional tables and stick with enums
            //modelBuilder.Entity<Variety>()
            //    .HasMany(e => e.Species)
            //    .WithMany(e => e.Varieties)
            //    .UsingEntity("VarietySpecies");

            //modelBuilder.Entity<Variety>()
            //    .HasMany(e => e.FruitSizes)
            //    .WithMany(e => e.Varieties)
            //    .UsingEntity("VarietyFruitSizes");

            //modelBuilder.Entity<Variety>()
            //    .HasMany(e => e.Images)
            //    .WithMany(e => e.Varieties)
            //    .UsingEntity("VarietyImages");

            ////Many-to-many
            //modelBuilder
            //    .Entity<VarietyPollenCompatibility>(entity =>
            //    {
            //        entity
            //            .HasOne(ub => ub.TargetVariety)
            //            .WithMany(x => x.IsPollenizedBy)
            //            .HasForeignKey(h => h.TargetVarietyId)
            //            .OnDelete(DeleteBehavior.Restrict);

            //        entity
            //            .HasOne(ub => ub.PollenizerVariety)
            //            .WithMany(x => x.IsPollenizerFor)
            //            .HasForeignKey(h => h.PollinizerVarietyId)
            //            .OnDelete(DeleteBehavior.Restrict);

            //        entity.HasKey(gu => new { gu.PollinizerVarietyId, gu.TargetVarietyId });

            //        entity.ToTable("VarietyPollenizers");
            //    });

            //modelBuilder
            //    .Entity<VarietyGraftingCompatibility>(entity =>
            //    {
            //        entity
            //            .HasOne(ub => ub.RootstockVariety)
            //            .WithMany(x => x.IsRootstockFor)
            //            .HasForeignKey(h => h.RootstockVarietyId)
            //            .OnDelete(DeleteBehavior.Restrict);

            //        entity
            //            .HasOne(ub => ub.GraftedVariety)
            //            .WithMany(x => x.IsGraftedOn)
            //            .HasForeignKey(h => h.GraftedVarietyId)
            //            .OnDelete(DeleteBehavior.Restrict);

            //        entity.HasKey(gu => new { gu.RootstockVarietyId, gu.GraftedVarietyId });

            //        entity.ToTable("VarietyGrafting");
            //    });
        }
    }
}