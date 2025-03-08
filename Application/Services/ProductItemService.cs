using Application.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Services;

public class ProductItemService
{
    private readonly IProductItemRepository _productItemRepository;
    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;
    private readonly IManufacturerRepository _manufacturerRepository;
    private readonly IBatchRepository _batchRepository;

    public ProductItemService(
        IProductItemRepository productItemRepository,
        IProductRepository productRepository,
        ICategoryRepository categoryRepository,
        IManufacturerRepository manufacturerRepository,
        IBatchRepository batchRepository)
    {
        _productItemRepository = productItemRepository;
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
        _manufacturerRepository = manufacturerRepository;
        _batchRepository = batchRepository;
    }

    // Добавление товарной единицы
    public async Task<Guid> AddProductItemAsync(string productName, string manufacturerName, string categoryName,
        string batchNumber, DateTime expiryDate, int quantity)
    {
        var manufacturer = await _manufacturerRepository.GetByNameAsync(manufacturerName);
        var category = await _categoryRepository.GetByNameAsync(categoryName);
        var batch = await _batchRepository.GetByBatchNumberAsync(batchNumber);

        if (manufacturer == null || category == null || batch == null)
            throw new ArgumentException("Производитель, категория или партия не найдены.");

        var product =
            await _productRepository.GetByDetailsAsync(productName, manufacturerName, categoryName, batchNumber);

        if (product == null)
            throw new ArgumentException("Товар не найден.");

        var productItem = new ProductItem
        {
            ProductId = product.ProductId,
            BatchId = batch.BatchId,
            ExpiryDate = expiryDate,
            Quantity = quantity
        };

        return _productItemRepository.Add(productItem);
    }

    // Обновление товарной единицы
    public async Task<Guid> UpdateProductItemAsync(Guid productItemId, DateTime expiryDate, int quantity)
    {
        var productItem = await _productItemRepository.GetByIdAsync(productItemId);
        if (productItem == null)
            throw new ArgumentException("Товарная единица не найдена.");

        productItem.ExpiryDate = expiryDate;
        productItem.Quantity = quantity;

        return _productItemRepository.Update(productItem);
    }

    // Удаление товарной единицы
    public async Task DeleteProductItemAsync(Guid productItemId)
    {
        var productItem = await _productItemRepository.GetByIdAsync(productItemId);
        if (productItem == null)
            throw new ArgumentException("Товарная единица не найдена.");

        await _productItemRepository.DeleteAsync(productItem);
    }

    // Получить товарные единицы по ID товара
    public async Task<ICollection<ProductItem>> GetProductItemsByProductIdAsync(Guid productId)
    {
        return await _productItemRepository.GetByProductIdAsync(productId);
    }

    // Получить все товарные единицы
    public async Task<ICollection<ProductItem>> GetAllProductItemsAsync()
    {
        return await _productItemRepository.GetAllAsync();
    }

    // Получить товарные единицы со скидкой из-за срока годности
    public async Task<ICollection<ProductItem>> GetDiscountedProductItemsAsync()
    {
        return await _productItemRepository.GetDiscountedItemsAsync();
    }
}