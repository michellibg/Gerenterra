using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjetoTerra.Models.Contexts;

namespace ProjetoTerra
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddEntityFrameworkNpgsql()
             .AddDbContext<GerenterraContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("Gerenterra")));

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
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }

        

        
    }
}
