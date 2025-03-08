using Domain.Entities;

namespace Application.Interfaces.Repositories;

/// <summary>
/// Репозиторий для работы с категориями товаров.
/// </summary>
public interface ICategoryRepository
{
    Task<Category?> GetByIdAsync(Guid id);
    Task<Category?> GetByNameAsync(string name);
    Task<ICollection<Category>> GetAllAsync();
    Guid Add(Category category);
    Guid Update(Category category);
    Task DeleteAsync(Category category);
}