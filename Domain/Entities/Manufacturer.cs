using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

/// <summary>
/// Производитель товаров.
/// </summary>
public class Manufacturer
{
    /// <summary>
    /// Уникальный идентификатор производителя.
    /// </summary>
    [Key]
    public Guid ManufacturerId { get; set; }

    /// <summary>
    /// Название производителя. Должно быть уникальным.
    /// </summary>
    [Required, MaxLength(255)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Контактная информация производителя (необязательное поле).
    /// </summary>
    [MaxLength(500)]
    public string? ContactInfo { get; set; }

    /// <summary>
    /// Список партий товаров, произведенных этим производителем.
    /// </summary>
    public ICollection<Batch> Batches { get; set; } = new List<Batch>();

    /// <summary>
    /// Список товаров, произведенных этим производителем.
    /// </summary>
    public ICollection<Product> Products { get; set; } = new List<Product>();
}