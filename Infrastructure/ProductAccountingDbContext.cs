using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

/// <summary>
/// Контекст базы данных приложения.
/// </summary>
public class ProductAccountingDbContext : DbContext
{
    public ProductAccountingDbContext(DbContextOptions<ProductAccountingDbContext> options)
        : base(options)
    {
    }

    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Batch> Batches { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductItem> ProductItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Manufacturer>()
            .HasIndex(m => m.Name)
            .IsUnique();

        modelBuilder.Entity<Category>()
            .HasIndex(c => c.Name)
            .IsUnique();

        modelBuilder.Entity<Batch>()
            .HasIndex(b => b.BatchNumber)
            .IsUnique();
    }
}