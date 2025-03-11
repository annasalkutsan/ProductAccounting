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
    public Guid AddProduct(string name, decimal price, DateTime expiryDate, string baschNumber, Guid manufacturerId, Guid categoryId)
    {
       var product = new Product(name, price, expiryDate, baschNumber, categoryId, manufacturerId);
 
        return _productRepository.Add(product);
    }

    // Обновление товара
    public Guid UpdateProduct(Guid productId, string name, decimal price, DateTime expiryDate, string baschNumber, Guid manufacturerId, Guid categoryId)
    {
        var product = _productRepository.GetById(productId);
        if (product == null)
            throw new ArgumentException("Товар не найден.");

        product.Name = name;
        product.ManufacturerId = manufacturerId;
        product.CategoryId = categoryId;
        product.Price = price;
        product.ExpiryDate = expiryDate.ToUniversalTime();
        product.BatchNumber = baschNumber;

        return _productRepository.Update(product);
    }

    // Удаление товара
    public void DeleteProduct(Guid productId)
    {
        var product = _productRepository.GetById(productId);
        if (product == null)
            throw new ArgumentException("Товар не найден.");

        _productRepository.Delete(product);
    }

    // Получить товар по ID
    public Product? GetProductById(Guid productId)
    {
        return _productRepository.GetById(productId);
    }

    // Получить все товары
    public ICollection<Product> GetAllProducts()
    {
        return _productRepository.GetAll();
    }

    // Получить товар по названию производителя, категории или номеру партии
    public Product? GetProductByDetails(string name)
    {
        return _productRepository.GetByDetails(name);
    }

    // Получить товарные единицы со скидкой из-за срока годности
    public ICollection<Product> GetDiscountedProducts()
    {
        return _productRepository.GetDiscountedProducts();
    }
}