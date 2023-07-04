using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using KestenApp.Data;

namespace KestenApp.Infrastructure.Extensions
{
    public static class ApplicationBuilderExtensions
    {

        public static IApplicationBuilder PrepareDatabase(
            this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var services = serviceScope.ServiceProvider;

            MigrateDatabase(services);

            ResetDatabase(services);

            SeedData seedData = new SeedData();
            SeedSpecies(services, seedData.Species);
            SeedFruitSizes(services, seedData.FruitSizes);
            SeedVarieties(services, seedData.Varieties);

            SeedAdministrator(services);

            return app;
        }

        private static void ResetDatabase(IServiceProvider services)
        {
            var data = services.GetRequiredService<KestenDbContext>();

            data.Database.EnsureDeleted();
            data.Database.EnsureCreated();
        }

        private static void MigrateDatabase(IServiceProvider services)
        {
            var data = services.GetRequiredService<KestenDbContext>();

            data.Database.Migrate();
        }

        private static void SeedSpecies(IServiceProvider services, IEnumerable<Data.Models.Species> species)
        {
            var data = services.GetRequiredService<KestenDbContext>();

            if (data.Species.Any())
            {
                return;
            }

            data.Species.AddRange(species);

            data.SaveChanges();
        }

        private static void SeedFruitSizes(IServiceProvider services, IEnumerable<Data.Models.FruitSize> fruitSizes)
        {
            var data = services.GetRequiredService<KestenDbContext>();

            if (data.FruitSizes.Any())
            {
                return;
            }

            data.FruitSizes.AddRange(fruitSizes);

            data.SaveChanges();
        }

        private static void SeedVarieties(IServiceProvider services, IEnumerable<Data.Models.Variety> varieties)
        {
            var data = services.GetRequiredService<KestenDbContext>();

            if (data.Varieties.Any())
            {
                return;
            }

            data.Varieties.AddRange(varieties);

            data.SaveChanges();
        }

        private static void SeedAdministrator(IServiceProvider services)
        {
            //var userManager = services.GetRequiredService<UserManager<User>>();
            //var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            //Task
            //    .Run(async () =>
            //    {
            //        if (await roleManager.RoleExistsAsync(AdministratorRoleName))
            //        {
            //            return;
            //        }

            //        var role = new IdentityRole { Name = AdministratorRoleName };

            //        await roleManager.CreateAsync(role);

            //        const string adminEmail = "admin@crs.com";
            //        const string adminPassword = "admin12";

            //        var user = new User
            //        {
            //            Email = adminEmail,
            //            UserName = adminEmail,
            //            FullName = "Admin"
            //        };

            //        await userManager.CreateAsync(user, adminPassword);

            //        await userManager.AddToRoleAsync(user, role.Name);
            //    })
            //    .GetAwaiter()
            //    .GetResult();
        }
    }
}