using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

/// <summary>
/// Партия товаров.
/// </summary>
public class Batch
{
    /// <summary>
    /// Уникальный идентификатор партии.
    /// </summary>
    [Key]
    public Guid BatchId { get; set; }

    /// <summary>
    /// Уникальный идентификатор производителя партии.
    /// </summary>
    [Required]
    [ForeignKey(nameof(Manufacturer))]
    public Guid ManufacturerId { get; set; }

    /// <summary>
    /// Номер партии. Должен быть уникальным.
    /// </summary>
    [Required, MaxLength(50)]
    public string BatchNumber { get; set; } = null!;

    /// <summary>
    /// Дата производства партии.
    /// </summary>
    [Required]
    public DateTime ManufactureDate { get; set; }

    /// <summary>
    /// Производитель данной партии.
    /// </summary>
    public Manufacturer Manufacturer { get; set; } = null!;

    /// <summary>
    /// Список товарных единиц, входящих в эту партию.
    /// </summary>
    public ICollection<ProductItem> ProductItems { get; set; } = new List<ProductItem>();
}