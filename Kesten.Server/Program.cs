using Kesten.Server.Common.Settings;
using Kesten.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace Kesten.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var settings = AppSettings.Load(builder.Environment);

            // Add bd context
            var connectionString = builder.Configuration
                .GetConnectionString("DbContextConnection")
                ?? throw new InvalidOperationException("Connection string 'KestenDbContextConnection' not found.");

            builder.Services.AddDbContext<KestenDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
                //options.EnableSensitiveDataLogging();
            });

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();

            //Add DI
            builder.Services.AddSingleton(settings);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsProduction())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            else
                app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}