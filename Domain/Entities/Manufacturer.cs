using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

/// <summary>
/// Производитель товаров.
/// </summary>
public class Manufacturer
{
    public Manufacturer(string name, string contactInfo)
    {
        ManufacturerId = Guid.NewGuid();
        Name = name;
        ContactInfo = contactInfo;
    }
    
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
    /// Список товаров, произведенных этим производителем.
    /// </summary>
    public ICollection<Product> Products { get; set; } = new List<Product>();
}