namespace KestenApp.Web
{
    using Microsoft.EntityFrameworkCore;

    using KestenApp.Services;
    using KestenApp.Services.Contracts;
    using KestenApp.Data;
    using KestenApp.Data.Models;
    using Microsoft.AspNetCore.Identity;

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
            {
                options.UseSqlServer(connectionString);
                //options.EnableSensitiveDataLogging();
            });

            //Identity
            builder.Services
                .AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount =
                        builder.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
                    options.Password.RequireLowercase =
                        builder.Configuration.GetValue<bool>("Identity:Password:RequireLowercase");
                    options.Password.RequireUppercase =
                        builder.Configuration.GetValue<bool>("Identity:Password:RequireUppercase");
                    options.Password.RequireNonAlphanumeric =
                        builder.Configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
                    options.Password.RequiredLength =
                        builder.Configuration.GetValue<int>("Identity:Password:RequiredLength");
                })
                .AddRoles<IdentityRole<Guid>>()
                .AddEntityFrameworkStores<KestenDbContext>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IVarietyService, VarietyService>();
            builder.Services.AddScoped<ISpeciesService, SpeciesService>();
            builder.Services.AddScoped<ISpecimenService, SpecimenService>();

            builder.Services.AddAntiforgery();

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