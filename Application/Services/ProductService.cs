using Application.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Services;

public class ProductService
{
    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;
    private readonly IManufacturerRepository _manufacturerRepository;

    public ProductService(
        IProductRepository productRepository,
        ICategoryRepository categoryRepository,
        IManufacturerRepository manufacturerRepository)
    {
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
        _manufacturerRepository = manufacturerRepository;
    }

    // Добавление товара
    public async Task<Guid> AddProductAsync(string name, string manufacturerName, string categoryName, decimal price)
    {
        var manufacturer = await _manufacturerRepository.GetByNameAsync(manufacturerName);
        var category = await _categoryRepository.GetByNameAsync(categoryName);

        if (manufacturer == null || category == null)
            throw new ArgumentException("Производитель или категория не найдены.");

        var product = new Product
        {
            Name = name,
            ManufacturerId = manufacturer.ManufacturerId,
            CategoryId = category.CategoryId,
            Price = price
        };

        return _productRepository.Add(product);
    }

    // Обновление товара
    public async Task<Guid> UpdateProductAsync(Guid productId, string name, string manufacturerName,
        string categoryName, decimal price)
    {
        var product = await _productRepository.GetByIdAsync(productId);
        if (product == null)
            throw new ArgumentException("Товар не найден.");

        var manufacturer = await _manufacturerRepository.GetByNameAsync(manufacturerName);
        var category = await _categoryRepository.GetByNameAsync(categoryName);

        if (manufacturer == null || category == null)
            throw new ArgumentException("Производитель или категория не найдены.");

        product.Name = name;
        product.ManufacturerId = manufacturer.ManufacturerId;
        product.CategoryId = category.CategoryId;
        product.Price = price;

        return _productRepository.Update(product);
    }

    // Удаление товара
    public async Task DeleteProductAsync(Guid productId)
    {
        var product = await _productRepository.GetByIdAsync(productId);
        if (product == null)
            throw new ArgumentException("Товар не найден.");

        await _productRepository.DeleteAsync(product);
    }

    // Получить товар по ID
    public async Task<Product?> GetProductByIdAsync(Guid productId)
    {
        return await _productRepository.GetByIdAsync(productId);
    }

    // Получить все товары
    public async Task<ICollection<Product>> GetAllProductsAsync()
    {
        return await _productRepository.GetAllAsync();
    }

    // Получить товар по названию производителя, категории или номеру партии
    public async Task<Product?> GetProductByDetailsAsync(string name, string manufacturerName, string categoryName,
        string batchNumber)
    {
        return await _productRepository.GetByDetailsAsync(name, manufacturerName, categoryName, batchNumber);
    }
}