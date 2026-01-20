
using Microsoft.EntityFrameworkCore;
using ScienceCalc.Data;

namespace ScienceCalc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ScienceCalcContext>(opt =>
                opt.UseNpgsql(builder.Configuration.GetConnectionString("ScienceCalcDb"))
            );

            builder.Services.AddOpenApi(); // whatever OpenAPI lib you're using

            var app = builder.Build();

            // Only in development: open OpenAPI UI
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi(); // or app.UseSwagger + app.UseSwaggerUI based on library
            }

            // Standard middleware order
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            // Map routes after UseRouting/UseAuthorization
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}"
            );

            app.MapControllers();

            app.Run();
        }
    }
}
