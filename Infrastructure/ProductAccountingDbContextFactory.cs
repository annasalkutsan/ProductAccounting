using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure;

/// <summary>
/// Фабрика для создания контекста БД во время миграций.
/// </summary>
public class ProductAccountingDbContextFactory : IDesignTimeDbContextFactory<ProductAccountingDbContext>
{
    public ProductAccountingDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<ProductAccountingDbContext>();
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        optionsBuilder.UseNpgsql(connectionString);

        return new ProductAccountingDbContext(optionsBuilder.Options);
    }
}