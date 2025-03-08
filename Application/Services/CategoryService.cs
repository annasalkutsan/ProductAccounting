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
    public async Task<Guid> AddCategoryAsync(string name)
    {
        var existingCategory = await _categoryRepository.GetByNameAsync(name);
        if (existingCategory != null)
            throw new ArgumentException("Категория с таким названием уже существует.");

        var category = new Category
        {
            Name = name
        };

        return _categoryRepository.Add(category);
    }

    // Обновление категории
    public async Task<Guid> UpdateCategoryAsync(Guid categoryId, string name)
    {
        var category = await _categoryRepository.GetByIdAsync(categoryId);
        if (category == null)
            throw new ArgumentException("Категория не найдена.");

        category.Name = name;

        return _categoryRepository.Update(category);
    }

    // Удаление категории
    public async Task DeleteCategoryAsync(Guid categoryId)
    {
        var category = await _categoryRepository.GetByIdAsync(categoryId);
        if (category == null)
            throw new ArgumentException("Категория не найдена.");

        await _categoryRepository.DeleteAsync(category);
    }

    // Получить категорию по ID
    public async Task<Category?> GetCategoryByIdAsync(Guid categoryId)
    {
        return await _categoryRepository.GetByIdAsync(categoryId);
    }

    // Получить все категории
    public async Task<ICollection<Category>> GetAllCategoriesAsync()
    {
        return await _categoryRepository.GetAllAsync();
    }

    // Получить категорию по названию
    public async Task<Category?> GetCategoryByNameAsync(string name)
    {
        return await _categoryRepository.GetByNameAsync(name);
    }
}