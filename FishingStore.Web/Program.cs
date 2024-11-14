using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using FishingStore.Data;
using FishingStore.Data.Models;
using FishingStore.Data.Repository;
using FishingStore.Data.Repository.Interfaces;
using FishingStore.Services.Data;
using FishingStore.Services.Data.Interfaces;

namespace FishingStore.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("Default") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<FishingStoreContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<FishingStoreContext>();

            builder.Services.AddScoped<IRepository<Rod, Guid>, Repository<Rod, Guid>>();
            builder.Services.AddScoped<IRepository<Reel, Guid>, Repository<Reel, Guid>>();
            builder.Services.AddScoped<IRepository<Hook, Guid>, Repository<Hook, Guid>>();
            builder.Services.AddScoped<IRepository<Line, Guid>, Repository<Line, Guid>>();
            builder.Services.AddScoped<IRepository<FullSet, Guid>, Repository<FullSet, Guid>>();

            builder.Services.AddScoped<IRodService, RodService>();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
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
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
