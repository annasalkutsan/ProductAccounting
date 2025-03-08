using Application.Interfaces.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

/// <summary>
/// Репозиторий для работы с категориями товаров.
/// </summary>
public class CategoryRepository : ICategoryRepository
{
    private readonly ProductAccountingDbContext _dbContext;

    public CategoryRepository(ProductAccountingDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Получить категорию по ID.
    /// </summary>
    public async Task<Category?> GetByIdAsync(Guid id)
    {
        return await _dbContext.Categories
            .FirstOrDefaultAsync(c => c.CategoryId == id);
    }

    /// <summary>
    /// Получить категорию по названию.
    /// </summary>
    public async Task<Category?> GetByNameAsync(string name)
    {
        return await _dbContext.Categories
            .FirstOrDefaultAsync(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Получить все категории.
    /// </summary>
    public async Task<ICollection<Category>> GetAllAsync()
    {
        return await _dbContext.Categories
            .AsNoTracking()
            .ToListAsync();
    }

    /// <summary>
    /// Добавить новую категорию.
    /// </summary>
    public Guid Add(Category category)
    {
        _dbContext.Categories.Add(category);
        _dbContext.SaveChanges();
        return category.CategoryId;
    }

    /// <summary>
    /// Обновить информацию о категории.
    /// </summary>
    public Guid Update(Category category)
    {
        _dbContext.Categories.Update(category);
        _dbContext.SaveChanges();
        return category.CategoryId;
    }

    /// <summary>
    /// Удалить категорию.
    /// </summary>
    public async Task DeleteAsync(Category category)
    {
        _dbContext.Categories.Remove(category);
        await _dbContext.SaveChangesAsync();
    }
}