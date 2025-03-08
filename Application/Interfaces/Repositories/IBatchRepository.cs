using Domain.Entities;

namespace Application.Interfaces.Repositories;

/// <summary>
/// Репозиторий для работы с партиями товаров.
/// </summary>
public interface IBatchRepository
{
    Task<Batch?> GetByIdAsync(Guid id);
    Task<Batch?> GetByBatchNumberAsync(string batchNumber);
    Task<ICollection<Batch>> GetAllAsync();
    Guid Add(Batch batch);
    Guid Update(Batch batch);
    Task DeleteAsync(Batch batch);
}