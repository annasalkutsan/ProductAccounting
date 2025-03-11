using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

/// <summary>
/// Категория товаров.
/// </summary>
public class Category
{
    public Category(string name)
    {
        CategoryId=Guid.NewGuid(); 
        Name=name;
    }

    /// <summary>
    /// Уникальный идентификатор категории.
    /// </summary>
    [Key]
    public Guid CategoryId { get; set; }

    /// <summary>
    /// Название категории. Должно быть уникальным.
    /// </summary>
    [Required, MaxLength(255)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Список товаров, относящихся к данной категории.
    /// </summary>
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
