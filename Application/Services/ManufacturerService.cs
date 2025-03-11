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
    public Guid AddManufacturer(string name, string? contactInfo)
    {
        var existingManufacturer = _manufacturerRepository.GetByName(name);
        if (existingManufacturer != null)
            throw new ArgumentException("Производитель с таким названием уже существует.");

        var manufacturer = new Manufacturer(name, contactInfo);

        return _manufacturerRepository.Add(manufacturer);
    }

    // Обновление производителя
    public Guid UpdateManufacturer(Guid manufacturerId, string name, string? contactInfo)
    {
        var manufacturer = _manufacturerRepository.GetById(manufacturerId);
        if (manufacturer == null)
            throw new ArgumentException("Производитель не найден.");

        manufacturer.Name = name;
        manufacturer.ContactInfo = contactInfo;

        return _manufacturerRepository.Update(manufacturer);
    }

    // Удаление производителя
    public void DeleteManufacturer(Guid manufacturerId)
    {
        var manufacturer = _manufacturerRepository.GetById(manufacturerId);
        if (manufacturer == null)
            throw new ArgumentException("Производитель не найден.");

        _manufacturerRepository.Delete(manufacturer);
    }

    // Получить производителя по ID
    public Manufacturer? GetManufacturerById(Guid manufacturerId)
    {
        return _manufacturerRepository.GetById(manufacturerId);
    }

    // Получить все производителей
    public ICollection<Manufacturer> GetAllManufacturers()
    {
        return _manufacturerRepository.GetAll();
    }

    // Получить производителя по названию
    public Manufacturer? GetManufacturerByName(string name)
    {
        return _manufacturerRepository.GetByName(name);
    }
}