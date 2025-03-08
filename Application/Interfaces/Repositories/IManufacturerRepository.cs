using Domain.Entities;

namespace Application.Interfaces.Repositories;

/// <summary>
/// Репозиторий для работы с производителями.
/// </summary>
public interface IManufacturerRepository
{
    Task<Manufacturer?> GetByIdAsync(Guid id);
    Task<Manufacturer?> GetByNameAsync(string name);
    Task<ICollection<Manufacturer>> GetAllAsync();
    Guid Add(Manufacturer manufacturer);
    Guid Update(Manufacturer manufacturer);
    Task DeleteAsync(Manufacturer manufacturer);
}