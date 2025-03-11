using Application.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Services;

public class CategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    // Добавление категории
    public Guid AddCategory(string name)
    {
        var existingCategory = _categoryRepository.GetByName(name);
        if (existingCategory != null)
            throw new ArgumentException("Категория с таким названием уже существует.");

        var category = new Category(name);

        return _categoryRepository.Add(category);
    }

    // Обновление категории
    public Guid UpdateCategory(Guid categoryId, string name)
    {
        var category = _categoryRepository.GetById(categoryId);
        if (category == null)
            throw new ArgumentException("Категория не найдена.");

        category.Name = name;

        return _categoryRepository.Update(category);
    }

    // Удаление категории
    public void DeleteCategory(Guid categoryId)
    {
        var category = _categoryRepository.GetById(categoryId);
        if (category == null)
            throw new ArgumentException("Категория не найдена.");

        _categoryRepository.Delete(category);
    }

    // Получить категорию по ID
    public Category? GetCategoryById(Guid categoryId)
    {
        return _categoryRepository.GetById(categoryId);
    }

    // Получить все категории
    public ICollection<Category> GetAllCategories()
    {
        return _categoryRepository.GetAll();
    }

    // Получить категорию по названию
    public Category? GetCategoryByName(string name)
    {
        return _categoryRepository.GetByName(name);
    }
}