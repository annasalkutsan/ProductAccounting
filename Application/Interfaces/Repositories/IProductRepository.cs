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
    Task<Product?> GetByIdAsync(Guid id);

    /// <summary>
    /// Получить товар по названию, производителю, категории или номеру партии.
    /// </summary>
    Task<Product?> GetByDetailsAsync(string? name, string? manufacturer, string? category, string? batchNumber);

    /// <summary>
    /// Получить все товары.
    /// </summary>
    Task<ICollection<Product>> GetAllAsync();

    /// <summary>
    /// Получить товары, которые находятся на скидке из-за истечения срока годности.
    /// </summary>
    Task<ICollection<ProductItem>> GetDiscountedProductsAsync();

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
    Task DeleteAsync(Product product);
}