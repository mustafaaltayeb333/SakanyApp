using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.EntityFrameworkCore;
using Sakany.Data;
using Sakany.Services;

namespace Sakany
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // ── MVC ───────────────────────────────────────
            builder.Services.AddControllersWithViews();

            // ── DATABASE ──────────────────────────────────
			
			string activeConnectionName = builder.Configuration["ActiveConnection"];
			
			string connectionString = builder.Configuration.GetConnectionString(activeConnectionName);
			
			
           builder.Services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(connectionString));

            // ── SESSION ───────────────────────────────────
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromHours(8);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.Cookie.Name = ".Sakany.Session";
            });
            builder.Services.AddHttpContextAccessor();

            // ── PDF ───────────────────────────────────────
            builder.Services.AddSingleton(typeof(IConverter),
                new SynchronizedConverter(new PdfTools()));

            // ── CUSTOM SERVICES ───────────────────────────
            builder.Services.AddScoped<PdfService>();
            builder.Services.AddScoped<EmailService>();

            // ─────────────────────────────────────────────
            var app = builder.Build();
            // ─────────────────────────────────────────────

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}