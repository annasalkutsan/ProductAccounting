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
    public Category? GetById(Guid id)
    {
        return _dbContext.Categories
            .FirstOrDefault(c => c.CategoryId == id);
    }

    /// <summary>
    /// Получить категорию по названию.
    /// </summary>
    public Category? GetByName(string name)
    {
        return _dbContext.Categories
            .FirstOrDefault(c => c.Name==name);
    }

    /// <summary>
    /// Получить все категории.
    /// </summary>
    public ICollection<Category> GetAll()
    {
        return _dbContext.Categories
            .AsNoTracking()
            .ToList();
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
    public void Delete(Category category)
    {
        _dbContext.Categories.Remove(category); 
        _dbContext.SaveChanges();
    }
}