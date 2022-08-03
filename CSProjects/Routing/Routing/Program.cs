using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

namespace Routing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "Chicken", 
                pattern: "EatMoreChicken", 
                new{controller= "Chicken", Action = "Index"});

            app.MapControllerRoute(
                name: "Chicken",
                pattern: "{*CowNum:int}",
                new { controller = "Cow", Action = "Index"});

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}