namespace Kesten.Server.Data
{
    using System.Reflection;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class KestenDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public KestenDbContext(DbContextOptions<KestenDbContext> options)
            : base(options)
        {
            // migrate any database changes on startup (includes initial db creation)

            //if (this.Database.GetPendingMigrations().Any())
            //{
            //    this.Database.Migrate();
            //}
        }

        public DbSet<Variety> Varieties { get; set; } = null!;
        public DbSet<Species> Species { get; set; } = null!;
        public DbSet<FruitSize> FruitSizes { get; set; } = null!;
        public DbSet<Garden> Gardens { get; set; } = null!;
        public DbSet<Specimen> Specimens { get; set; } = null!;

        //Varieties
        public DbSet<VarietySpecies> VarietySpecies { get; set; } = null!;
        public DbSet<VarietyFruitSize> VarietyFruitSizes { get; set; } = null!;
        public DbSet<VarietyPollenCompatibility> VarietyPollenizers { get; set; } = null!;
        public DbSet<VarietyGraftingCompatibility> VarietyGrafting { get; set; } = null!;
        public DbSet<VarietyImage> VarietyImages { get; set; } = null!;        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(KestenDbContext)) ??
                                      Assembly.GetExecutingAssembly();
            builder.ApplyConfigurationsFromAssembly(configAssembly);

            //Needed for Identity
            base.OnModelCreating(builder);
        }
    }
}