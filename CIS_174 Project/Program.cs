using CIS_174_Project.Models.Olympics;
using CIS_174_Project.Models.ToDoList;
using Microsoft.EntityFrameworkCore;

namespace CIS_174_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddMemoryCache();
            builder.Services.AddSession();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<CountryContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContryContext")));

            builder.Services.AddDbContext<ToDoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ToDoContext")));

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

            app.UseAuthorization();

            app.UseSession();

            app.MapControllerRoute(
                name: "olympicsRoute",
                pattern: "{controller=Home}/{action=Index}/type-{activeSportType=all}/game-{activeGameType=all}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
