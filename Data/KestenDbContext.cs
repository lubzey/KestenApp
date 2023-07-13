using KestenApp.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Tracing;

namespace KestenApp.Data
{
    public class KestenDbContext : IdentityDbContext
    {
        public DbSet<Variety> Varieties { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<FruitSize> FruitSizes { get; set; }
        public DbSet<VarietyPollenCompatibility> VarietyPollenizers { get; set; }
        public DbSet<VarietyGraftingCompatibility> VarietyGrafting { get; set; }
        public DbSet<Image> Images { get; set; }

        public KestenDbContext(DbContextOptions<KestenDbContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder
        //        .UseSqlServer(
        //            "Data Source = DESKTOP-LM5NNI0;" + //Server name
        //            "Initial Catalog = KestenDB;" + //Database name
        //            "Trusted_Connection=True; " +
        //            "TrustServerCertificate=True")
        //        .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking) //Disable object tracking (good for web/mobile apps in terms of performance)
        //        .LogTo( //Automatically log queries
        //            Console.WriteLine,
        //            new[] { DbLoggerCategory.Database.Command.Name },
        //            LogLevel.Information)
        //        .EnableSensitiveDataLogging(); //Log parameter values
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Needed for Identity
            base.OnModelCreating(modelBuilder);

            //Default value
            modelBuilder.Entity<Variety>()
               .Property(v => v.DateCreated)
               .HasDefaultValueSql("getdate()");

            //todo:Remove additional tables and stick with enums
            modelBuilder.Entity<Variety>()
                .HasMany(e => e.Species)
                .WithMany(e => e.Varieties)
                .UsingEntity("VarietySpecies");

            modelBuilder.Entity<Variety>()
                .HasMany(e => e.FruitSizes)
                .WithMany(e => e.Varieties)
                .UsingEntity("VarietyFruitSizes");

            modelBuilder.Entity<Variety>()
                .HasMany(e => e.Images)
                .WithMany(e => e.Varieties)
                .UsingEntity("VarietyImages");

            //Many-to-many
            modelBuilder
                .Entity<VarietyPollenCompatibility>(entity =>
                {
                    entity
                        .HasOne(ub => ub.TargetVariety)
                        .WithMany(x => x.IsPollenizedBy)
                        .HasForeignKey(h => h.TargetVarietyId)
                        .OnDelete(DeleteBehavior.Restrict);

                    entity
                        .HasOne(ub => ub.PollenizerVariety)
                        .WithMany(x => x.IsPollenizerFor)
                        .HasForeignKey(h => h.PollinizerVarietyId)
                        .OnDelete(DeleteBehavior.Restrict);

                    entity.HasKey(gu => new { gu.PollinizerVarietyId, gu.TargetVarietyId });

                    entity.ToTable("VarietyPollenizers");
                });

            modelBuilder
                .Entity<VarietyGraftingCompatibility>(entity =>
                {
                    entity
                        .HasOne(ub => ub.RootstockVariety)
                        .WithMany(x => x.IsRootstockFor)
                        .HasForeignKey(h => h.RootstockVarietyId)
                        .OnDelete(DeleteBehavior.Restrict);

                    entity
                        .HasOne(ub => ub.GraftedVariety)
                        .WithMany(x => x.IsGraftedOn)
                        .HasForeignKey(h => h.GraftedVarietyId)
                        .OnDelete(DeleteBehavior.Restrict);

                    entity.HasKey(gu => new { gu.RootstockVarietyId, gu.GraftedVarietyId });

                    entity.ToTable("VarietyGrafting");
                });
        }
    }
}