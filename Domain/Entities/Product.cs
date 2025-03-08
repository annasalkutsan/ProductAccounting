using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

/// <summary>
/// Товар.
/// </summary>
public class Product
{
    [Key]
    public Guid ProductId { get; set; }

    /// <summary>
    /// Название товара.
    /// </summary>
    [Required, MaxLength(255)]
    public string Name { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(Category))]
    public Guid CategoryId { get; set; }

    [Required]
    [ForeignKey(nameof(Manufacturer))]
    public Guid ManufacturerId { get; set; }

    /// <summary>
    /// Базовая цена товара.
    /// </summary>
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    public Category Category { get; set; } = null!;
    public Manufacturer Manufacturer { get; set; } = null!;

    public ICollection<ProductItem> ProductItems { get; set; } = new List<ProductItem>();
}