using Microsoft.EntityFrameworkCore;
using KestenTestApp.Models.Repositories;
using KestenTestApp.Models.Database;
using Microsoft.AspNetCore.Identity;

namespace KestenTestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add bd context
            var connectionString = builder.Configuration
                .GetConnectionString("KestenDbContextConnection")
                ?? throw new InvalidOperationException("Connection string 'KestenDbContextConnection' not found.");

            builder.Services.AddDbContext<KestenDbContext>(options =>
                options.UseSqlServer(connectionString));

            //Identity
            builder.Services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<KestenDbContext>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IVarietyRepository, VarietyRepository>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Variety}/{action=List}/{id?}");

            app.MapRazorPages();

            //DbInitializer.Seed(app);

            app.Run();
        }
    }
}