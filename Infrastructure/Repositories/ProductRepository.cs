using Application.Interfaces.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

/// <summary>
/// Репозиторий для работы с товарами.
/// </summary>
public class ProductRepository : IProductRepository
{
    private readonly ProductAccountingDbContext _dbContext;

    public ProductRepository(ProductAccountingDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Получить товар по ID.
    /// </summary>
    public Product? GetById(Guid id)
    {
        return _dbContext.Products
            .FirstOrDefault(p => p.ProductId == id);
    }

    /// <summary>
    /// Получить товар по названию, производителю, категории или номеру партии.
    /// </summary>
    public Product? GetByDetails(string? name)
    {
        var query = _dbContext.Products.AsQueryable();

        if (!string.IsNullOrEmpty(name))
            query = query.Where(p => p.Name == name);

        return query.FirstOrDefault();
    }

    /// <summary>
    /// Получить все товары.
    /// </summary>
    public ICollection<Product> GetAll()
    {
        return _dbContext.Products
            .AsNoTracking()
            .ToList();
    }

    /// <summary>
    /// Получить товары, которые находятся на скидке из-за истечения срока годности.
    /// </summary>
    public ICollection<Product> GetDiscountedProducts()
    {
        var products = _dbContext.Products
            .Where(p => p.ExpiryDate <= DateTime.Now.AddDays(14).ToUniversalTime())
            .ToList();

        // Применяем скидку к цене товаров в памяти
        foreach (var product in products)
        {
            product.DiscountedPrice = product.DiscountedPrice;
        }

        return products;
    }

    /// <summary>
    /// Добавить новый товар.
    /// </summary>
    public Guid Add(Product product)
    {
        _dbContext.Products.Add(product);
        _dbContext.SaveChanges();
        return product.ProductId;
    }

    /// <summary>
    /// Обновить данные товара.
    /// </summary>
    public Guid Update(Product product)
    {
        _dbContext.Products.Update(product);
        _dbContext.SaveChanges();
        return product.ProductId;
    }

    /// <summary>
    /// Удалить товар.
    /// </summary>
    public void Delete(Product product)
    {
        _dbContext.Products.Remove(product); 
        _dbContext.SaveChanges();
    }
}