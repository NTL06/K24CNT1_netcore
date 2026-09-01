namespace NTLLesson04
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            // Cho phép sử dụng CSS, JS, hình ảnh trong wwwroot
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            // Route mặc định
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Route cho NTLAccount
            app.MapControllerRoute(
                name: "nTLAccount",
                pattern: "{controller=NTLAccount}/{action=NTLIndex}/{id?}");

            app.Run();
        }
    }
}