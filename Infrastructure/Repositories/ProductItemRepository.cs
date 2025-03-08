using Application.Interfaces.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

/// <summary>
/// Репозиторий для работы с конкретными товарными единицами.
/// </summary>
public class ProductItemRepository : IProductItemRepository
{
    private readonly ProductAccountingDbContext _dbContext;

    public ProductItemRepository(ProductAccountingDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Получить товарную единицу по ID.
    /// </summary>
    public async Task<ProductItem?> GetByIdAsync(Guid id)
    {
        return await _dbContext.ProductItems
            .FirstOrDefaultAsync(pi => pi.ProductItemId == id);
    }

    /// <summary>
    /// Получить все товарные единицы по ID товара.
    /// </summary>
    public async Task<ICollection<ProductItem>> GetByProductIdAsync(Guid productId)
    {
        return await _dbContext.ProductItems
            .Where(pi => pi.ProductId == productId)
            .ToListAsync();
    }

    /// <summary>
    /// Получить все товарные единицы.
    /// </summary>
    public async Task<ICollection<ProductItem>> GetAllAsync()
    {
        return await _dbContext.ProductItems
            .AsNoTracking()
            .ToListAsync();
    }

    /// <summary>
    /// Получить все товарные единицы, которые находятся на скидке.
    /// </summary>
    public async Task<ICollection<ProductItem>> GetDiscountedItemsAsync()
    {
        return await _dbContext.ProductItems
            .Where(pi => (pi.ExpiryDate - DateTime.UtcNow).TotalDays <= 14)
            .ToListAsync();
    }

    /// <summary>
    /// Добавить новую товарную единицу.
    /// </summary>
    public Guid Add(ProductItem productItem)
    {
        _dbContext.ProductItems.Add(productItem);
        _dbContext.SaveChanges();
        return productItem.ProductItemId;
    }

    /// <summary>
    /// Обновить товарную единицу.
    /// </summary>
    public Guid Update(ProductItem productItem)
    {
        _dbContext.ProductItems.Update(productItem);
        _dbContext.SaveChanges();
        return productItem.ProductItemId;
    }

    /// <summary>
    /// Удалить товарную единицу.
    /// </summary>
    public async Task DeleteAsync(ProductItem productItem)
    {
        _dbContext.ProductItems.Remove(productItem);
        await _dbContext.SaveChangesAsync();
    }
}