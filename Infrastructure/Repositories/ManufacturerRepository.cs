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
    public async Task<Manufacturer?> GetByIdAsync(Guid id)
    {
        return await _dbContext.Manufacturers
            .FirstOrDefaultAsync(m => m.ManufacturerId == id);
    }

    /// <summary>
    /// Получить производителя по названию.
    /// </summary>
    public async Task<Manufacturer?> GetByNameAsync(string name)
    {
        return await _dbContext.Manufacturers
            .FirstOrDefaultAsync(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Получить всех производителей.
    /// </summary>
    public async Task<ICollection<Manufacturer>> GetAllAsync()
    {
        return await _dbContext.Manufacturers
            .AsNoTracking()
            .ToListAsync();
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
    public async Task DeleteAsync(Manufacturer manufacturer)
    {
        _dbContext.Manufacturers.Remove(manufacturer);
        await _dbContext.SaveChangesAsync();
    }
}