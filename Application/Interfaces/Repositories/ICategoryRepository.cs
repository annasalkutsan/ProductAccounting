using Domain.Entities;

namespace Application.Interfaces.Repositories;

/// <summary>
/// Репозиторий для работы с категориями товаров.
/// </summary>
public interface ICategoryRepository
{
    Category? GetById(Guid id);
    Category? GetByName(string name);
    ICollection<Category> GetAll();
    Guid Add(Category category);
    Guid Update(Category category);
    void Delete(Category category);
}