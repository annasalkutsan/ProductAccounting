using Domain.Entities;

namespace Application.Interfaces.Repositories;

/// <summary>
/// Репозиторий для работы с производителями.
/// </summary>
public interface IManufacturerRepository
{
    Manufacturer? GetById(Guid id);
    Manufacturer? GetByName(string name);
    ICollection<Manufacturer> GetAll();
    Guid Add(Manufacturer manufacturer);
    Guid Update(Manufacturer manufacturer);
    void Delete(Manufacturer manufacturer);
}