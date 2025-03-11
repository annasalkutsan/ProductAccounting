using Application.Interfaces.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

/// <summary>
/// Репозиторий для работы с производителями.
/// </summary>
public class ManufacturerRepository : IManufacturerRepository
{
    private readonly ProductAccountingDbContext _dbContext;

    public ManufacturerRepository(ProductAccountingDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Получить производителя по ID.
    /// </summary>
    public Manufacturer? GetById(Guid id)
    {
        return _dbContext.Manufacturers
            .FirstOrDefault(m => m.ManufacturerId == id);
    }

    /// <summary>
    /// Получить производителя по названию.
    /// </summary>
    public Manufacturer? GetByName(string name)
    {
        return _dbContext.Manufacturers
            .FirstOrDefault(m => m.Name == name);
    }

    /// <summary>
    /// Получить всех производителей.
    /// </summary>
    public ICollection<Manufacturer> GetAll()
    {
        return _dbContext.Manufacturers
            .AsNoTracking()
            .ToList();
    }

    /// <summary>
    /// Добавить нового производителя.
    /// </summary>
    public Guid Add(Manufacturer manufacturer)
    {
        _dbContext.Manufacturers.Add(manufacturer);
        _dbContext.SaveChanges();
        return manufacturer.ManufacturerId;
    }

    /// <summary>
    /// Обновить информацию о производителе.
    /// </summary>
    public Guid Update(Manufacturer manufacturer)
    {
        _dbContext.Manufacturers.Update(manufacturer);
        _dbContext.SaveChanges();
        return manufacturer.ManufacturerId;
    }

    /// <summary>
    /// Удалить производителя.
    /// </summary>
    public void Delete(Manufacturer manufacturer)
    {
        _dbContext.Manufacturers.Remove(manufacturer);
        _dbContext.SaveChanges();
    }
}