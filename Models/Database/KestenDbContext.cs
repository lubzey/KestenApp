using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Tracing;

namespace KestenTestApp.Models.Database
{
    public class KestenDbContext : DbContext
    {
        public DbSet<Variety> Varieties { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<FruitSize> FruitSizes { get; set; }
        public DbSet<PollenizerTarget> PollenizerTargets { get; set; }

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
            modelBuilder.Entity<Variety>()
                .HasMany(e => e.Species)
                .WithMany(e => e.Varieties)
                .UsingEntity("VarietySpecies");

            modelBuilder.Entity<Variety>()
                .HasMany(e => e.FruitSizes)
                .WithMany(e => e.Varieties)
                .UsingEntity("VarietyFruitSizes");

            modelBuilder
                .Entity<PollenizerTarget>(entity =>
                {
                    entity
                        .HasOne(ub => ub.TargetVariety)
                        .WithMany(x => x.Pollenizers)
                        .HasForeignKey(h => h.TargetVarietyId)
                        .OnDelete(DeleteBehavior.Restrict);

                    entity
                        .HasOne(ub => ub.PollenizerVariety)
                        .WithMany(x => x.PollenizerTargets)
                        .HasForeignKey(h => h.PollinizerVarietyId)
                        .OnDelete(DeleteBehavior.Restrict);

                    entity.HasKey(gu => new { gu.PollinizerVarietyId, gu.TargetVarietyId });

                    entity.ToTable("VarietyPollenizers");
                });
        }
    }
}