using Kesten.Api.Data;
using Kesten.Api.Services;
using Kesten.Api.Settings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;

namespace Kesten.Api
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

            builder.Services.AddDbContextFactory<KestenDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
                //options.EnableSensitiveDataLogging();
            });

            // Add services to the container.

            builder.Services.AddScoped<IVarietyRepository, VarietyRepository>();

            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, c =>
                {
                    c.Authority = $"https://{builder.Configuration["Auth0:Domain"]}";
                    c.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                    {
                        ValidAudience = builder.Configuration["Auth0:Audience"],
                        ValidIssuer = $"https://{builder.Configuration["Auth0:Domain"]}"
                    };
                });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
