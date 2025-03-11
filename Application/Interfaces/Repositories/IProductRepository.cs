using Domain.Entities;

namespace Application.Interfaces.Repositories;

/// <summary>
/// Репозиторий для работы с товарами.
/// </summary>
public interface IProductRepository
{
    /// <summary>
    /// Получить товар по ID.
    /// </summary>
    Product? GetById(Guid id);

    /// <summary>
    /// Получить товар по названию, производителю, категории или номеру партии.
    /// </summary>
    Product? GetByDetails(string? name);

    /// <summary>
    /// Получить все товары.
    /// </summary>
    ICollection<Product> GetAll();

    /// <summary>
    /// Получить товары, которые находятся на скидке из-за истечения срока годности.
    /// </summary>
    ICollection<Product> GetDiscountedProducts();

    /// <summary>
    /// Добавить новый товар.
    /// </summary>
    Guid Add(Product product);

    /// <summary>
    /// Обновить данные товара.
    /// </summary>
    Guid Update(Product product);

    /// <summary>
    /// Удалить товар.
    /// </summary>
    void Delete(Product product);
}