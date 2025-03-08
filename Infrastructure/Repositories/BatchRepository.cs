using Application.Interfaces.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

/// <summary>
/// Репозиторий для работы с партиями товаров.
/// </summary>
public class BatchRepository : IBatchRepository
{
    private readonly ProductAccountingDbContext _dbContext;

    public BatchRepository(ProductAccountingDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Получить партию по ID.
    /// </summary>
    public async Task<Batch?> GetByIdAsync(Guid id)
    {
        return await _dbContext.Batches
            .FirstOrDefaultAsync(b => b.BatchId == id);
    }

    /// <summary>
    /// Получить партию по номеру партии.
    /// </summary>
    public async Task<Batch?> GetByBatchNumberAsync(string batchNumber)
    {
        return await _dbContext.Batches
            .FirstOrDefaultAsync(b => b.BatchNumber == batchNumber);
    }

    /// <summary>
    /// Получить все партии товаров.
    /// </summary>
    public async Task<ICollection<Batch>> GetAllAsync()
    {
        return await _dbContext.Batches
            .AsNoTracking()
            .ToListAsync();
    }

    /// <summary>
    /// Добавить новую партию товаров.
    /// </summary>
    public Guid Add(Batch batch)
    {
        _dbContext.Batches.Add(batch);
        _dbContext.SaveChanges();
        return batch.BatchId;
    }

    /// <summary>
    /// Обновить информацию о партии товаров.
    /// </summary>
    public Guid Update(Batch batch)
    {
        _dbContext.Batches.Update(batch);
        _dbContext.SaveChanges();
        return batch.BatchId;
    }

    /// <summary>
    /// Удалить партию товаров.
    /// </summary>
    public async Task DeleteAsync(Batch batch)
    {
        _dbContext.Batches.Remove(batch);
        await _dbContext.SaveChangesAsync();
    }
}