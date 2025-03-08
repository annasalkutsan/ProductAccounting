using Application.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Services;

public class BatchService
{
    private readonly IBatchRepository _batchRepository;
    private readonly IManufacturerRepository _manufacturerRepository;

    public BatchService(IBatchRepository batchRepository, IManufacturerRepository manufacturerRepository)
    {
        _batchRepository = batchRepository;
        _manufacturerRepository = manufacturerRepository;
    }

    // Добавление партии
    public async Task<Guid> AddBatchAsync(string batchNumber, string manufacturerName, DateTime manufactureDate)
    {
        var manufacturer = await _manufacturerRepository.GetByNameAsync(manufacturerName);
        if (manufacturer == null)
            throw new ArgumentException("Производитель не найден.");

        var batch = new Batch
        {
            BatchNumber = batchNumber,
            ManufacturerId = manufacturer.ManufacturerId,
            ManufactureDate = manufactureDate
        };

        return _batchRepository.Add(batch);
    }

    // Обновление партии
    public async Task<Guid> UpdateBatchAsync(Guid batchId, string batchNumber, DateTime manufactureDate)
    {
        var batch = await _batchRepository.GetByIdAsync(batchId);
        if (batch == null)
            throw new ArgumentException("Партия не найдена.");

        batch.BatchNumber = batchNumber;
        batch.ManufactureDate = manufactureDate;

        return _batchRepository.Update(batch);
    }

    // Удаление партии
    public async Task DeleteBatchAsync(Guid batchId)
    {
        var batch = await _batchRepository.GetByIdAsync(batchId);
        if (batch == null)
            throw new ArgumentException("Партия не найдена.");

        await _batchRepository.DeleteAsync(batch);
    }

    // Получить партию по ID
    public async Task<Batch?> GetBatchByIdAsync(Guid batchId)
    {
        return await _batchRepository.GetByIdAsync(batchId);
    }

    // Получить все партии
    public async Task<ICollection<Batch>> GetAllBatchesAsync()
    {
        return await _batchRepository.GetAllAsync();
    }

    // Получить партию по номеру партии
    public async Task<Batch?> GetBatchByNumberAsync(string batchNumber)
    {
        return await _batchRepository.GetByBatchNumberAsync(batchNumber);
    }
}