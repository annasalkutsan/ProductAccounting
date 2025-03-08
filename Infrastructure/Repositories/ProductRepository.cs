using Application.Interfaces.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

/// <summary>
/// Репозиторий для работы с товарами.
/// </summary>
public class ProductRepository : IProductRepository
{
    private readonly ProductAccountingDbContext _dbContext;

    public ProductRepository(ProductAccountingDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Получить товар по ID.
    /// </summary>
    public async Task<Product?> GetByIdAsync(Guid id)
    {
        return await _dbContext.Products
            .FirstOrDefaultAsync(p => p.ProductId == id);
    }

    /// <summary>
    /// Получить товар по названию, производителю, категории или номеру партии.
    /// </summary>
    public async Task<Product?> GetByDetailsAsync(string? name, string? manufacturer, string? category,
        string? batchNumber)
    {
        var query = _dbContext.Products.AsQueryable();

        if (!string.IsNullOrEmpty(name))
            query = query.Where(p => p.Name.Contains(name));

        if (!string.IsNullOrEmpty(manufacturer))
            query = query.Where(p => p.Manufacturer.Name.Contains(manufacturer));

        if (!string.IsNullOrEmpty(category))
            query = query.Where(p => p.Category.Name.Contains(category));

        if (!string.IsNullOrEmpty(batchNumber))
            query = query.Where(p => p.ProductItems.Any(p => p.Batch.BatchNumber.Contains(batchNumber)));

        return await query.FirstOrDefaultAsync();
    }

    /// <summary>
    /// Получить все товары.
    /// </summary>
    public async Task<ICollection<Product>> GetAllAsync()
    {
        return await _dbContext.Products
            .AsNoTracking()
            .ToListAsync();
    }

    /// <summary>
    /// Получить товары, которые находятся на скидке из-за истечения срока годности.
    /// </summary>
    public async Task<ICollection<ProductItem>> GetDiscountedProductsAsync()
    {
        return await _dbContext.ProductItems
            .Where(pi => pi.ExpiryDate <= DateTime.Now.AddDays(14))
            .ToListAsync();
    }

    /// <summary>
    /// Добавить новый товар.
    /// </summary>
    public Guid Add(Product product)
    {
        _dbContext.Products.Add(product);
        _dbContext.SaveChanges();
        return product.ProductId;
    }

    /// <summary>
    /// Обновить данные товара.
    /// </summary>
    public Guid Update(Product product)
    {
        _dbContext.Products.Update(product);
        _dbContext.SaveChanges();
        return product.ProductId;
    }

    /// <summary>
    /// Удалить товар.
    /// </summary>
    public async Task DeleteAsync(Product product)
    {
        _dbContext.Products.Remove(product);
        await _dbContext.SaveChangesAsync();
    }
}