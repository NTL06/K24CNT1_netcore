using Microsoft.EntityFrameworkCore;
using NTLLesson10EFDb.Models;

namespace NTLLesson10EFDb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //lấy chuỗi kết nốt từ appsetting.json
            var nTLConnection = builder.Configuration.GetConnectionString("NTLK24CNT1Lesson10");
            builder.Services.AddDbContext<Ntllesson10EfdbContext>(x => x.UseSqlServer(nTLConnection));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
