using webuygulama.context;
using webuygulama.service;

namespace webuygulama
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<NorthwindContext, NorthwindContext>();

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
                pattern: "Home/Index/{Id?}",
                defaults: new {controller = "Home",action="Index"});
        

            app.Run();
        }
    }
}
