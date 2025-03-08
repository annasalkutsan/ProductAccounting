using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

/// <summary>
/// Конкретная товарная единица в партии.
/// </summary>
public class ProductItem
{
    [Key]
    public Guid ProductItemId { get; set; }

    [Required]
    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }

    [Required]
    [ForeignKey(nameof(Batch))]
    public Guid BatchId { get; set; }

    /// <summary>
    /// Дата истечения срока годности товара.
    /// </summary>
    [Required]
    public DateTime ExpiryDate { get; set; }

    public DateTime? PurchaseDate { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Quantity { get; set; }

    public Product Product { get; set; } = null!;
    public Batch Batch { get; set; } = null!;

    /// <summary>
    /// Цена с учетом скидки (если осталось ≤ 2 недели до истечения срока).
    /// </summary>
    [NotMapped]
    public decimal DiscountedPrice =>
        (ExpiryDate - DateTime.UtcNow).TotalDays <= 14 ? Product.Price * 0.7m : Product.Price;
}