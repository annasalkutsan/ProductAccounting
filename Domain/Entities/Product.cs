using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

/// <summary>
/// Товар.
/// </summary>
public class Product
{
    public Product(string name, decimal price, DateTime expiryDate, string baschNumber, Guid categoryId, Guid manufacturerId)
    {
        ProductId = Guid.NewGuid();
        Name = name;
        Price = price;
        ExpiryDate = expiryDate.ToUniversalTime();
        Price= price;
        BatchNumber = baschNumber;
        CategoryId = categoryId;
        ManufacturerId = manufacturerId;
    }
    public Product() { }

    [Key] public Guid ProductId { get; set; }

    /// <summary>
    /// Название товара.
    /// </summary>
    [Required, MaxLength(255)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Базовая цена товара.
    /// </summary>
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    /// <summary>
    /// Дата истечения срока годности товара.
    /// </summary>
    [Required]
    public DateTime ExpiryDate { get; set; }

    /// <summary>
    /// Цена с учетом скидки (если осталось ≤ 2 недели до истечения срока).
    /// </summary>
    [NotMapped]
    public decimal DiscountedPrice
    {
        get => (ExpiryDate - DateTime.UtcNow).TotalDays <= 14 ? Price * 0.7m : Price;
        set { }
    }

    /// <summary>
    /// Номер партии
    /// </summary>
    public string BatchNumber { get; set; }
    
    [Required]
    [ForeignKey(nameof(Category))]
    public Guid CategoryId { get; set; }

    [Required]
    [ForeignKey(nameof(Manufacturer))]
    public Guid ManufacturerId { get; set; }

    public Category Category { get; set; } = null!;
    public Manufacturer Manufacturer { get; set; } = null!;
}