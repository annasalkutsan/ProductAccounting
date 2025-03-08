using Application.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Services;

public class ManufacturerService
{
    private readonly IManufacturerRepository _manufacturerRepository;

    public ManufacturerService(IManufacturerRepository manufacturerRepository)
    {
        _manufacturerRepository = manufacturerRepository;
    }

    // Добавление производителя
    public async Task<Guid> AddManufacturerAsync(string name, string? contactInfo)
    {
        var existingManufacturer = await _manufacturerRepository.GetByNameAsync(name);
        if (existingManufacturer != null)
            throw new ArgumentException("Производитель с таким названием уже существует.");

        var manufacturer = new Manufacturer
        {
            Name = name,
            ContactInfo = contactInfo
        };

        return _manufacturerRepository.Add(manufacturer);
    }

    // Обновление производителя
    public async Task<Guid> UpdateManufacturerAsync(Guid manufacturerId, string name, string? contactInfo)
    {
        var manufacturer = await _manufacturerRepository.GetByIdAsync(manufacturerId);
        if (manufacturer == null)
            throw new ArgumentException("Производитель не найден.");

        manufacturer.Name = name;
        manufacturer.ContactInfo = contactInfo;

        return _manufacturerRepository.Update(manufacturer);
    }

    // Удаление производителя
    public async Task DeleteManufacturerAsync(Guid manufacturerId)
    {
        var manufacturer = await _manufacturerRepository.GetByIdAsync(manufacturerId);
        if (manufacturer == null)
            throw new ArgumentException("Производитель не найден.");

        await _manufacturerRepository.DeleteAsync(manufacturer);
    }

    // Получить производителя по ID
    public async Task<Manufacturer?> GetManufacturerByIdAsync(Guid manufacturerId)
    {
        return await _manufacturerRepository.GetByIdAsync(manufacturerId);
    }

    // Получить все производителей
    public async Task<ICollection<Manufacturer>> GetAllManufacturersAsync()
    {
        return await _manufacturerRepository.GetAllAsync();
    }

    // Получить производителя по названию
    public async Task<Manufacturer?> GetManufacturerByNameAsync(string name)
    {
        return await _manufacturerRepository.GetByNameAsync(name);
    }
}