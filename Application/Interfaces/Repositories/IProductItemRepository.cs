using Domain.Entities;

namespace Application.Interfaces.Repositories;

/// <summary>
/// Репозиторий для работы с конкретными товарными единицами.
/// </summary>
public interface IProductItemRepository
{
    Task<ProductItem?> GetByIdAsync(Guid id);
    Task<ICollection<ProductItem>> GetByProductIdAsync(Guid productId);
    Task<ICollection<ProductItem>> GetAllAsync();
    Task<ICollection<ProductItem>> GetDiscountedItemsAsync();
    Guid Add(ProductItem productItem);
    Guid Update(ProductItem productItem);
    Task DeleteAsync(ProductItem productItem);
}