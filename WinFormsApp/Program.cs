using Infrastructure;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Application.Interfaces.Repositories;
using Application.Services;

namespace WinFormsApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();

            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;

            System.Windows.Forms.Application.Run(new Main(
                services.GetRequiredService<ProductService>(),
                services.GetRequiredService<ManufacturerService>(),
                services.GetRequiredService<CategoryService>()));
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<ProductAccountingDbContext>(options =>
                        options.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=12345;Database=ProductAccountingDb"));

                    services.AddScoped<IProductRepository, ProductRepository>();
                    services.AddScoped<IManufacturerRepository, ManufacturerRepository>();
                    services.AddScoped<ICategoryRepository, CategoryRepository>();

                    services.AddScoped<ProductService>();
                    services.AddScoped<ManufacturerService>();
                    services.AddScoped<CategoryService>();
                });
    }
}
