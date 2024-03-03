using iApple.Service.DTOs.Categories;

namespace iApple.Service.Interfaces;

public interface ICategoryService
{
    ValueTask<bool> DeleteAsync(int id);
    ValueTask<CategoryViewModel> GetByIdAsync(int id);
    ValueTask<List<CategoryViewModel>> GetAllCategoriesAsync();
    ValueTask<CategoryViewModel> CreateAsync(CategoryCreationModel categoryCreation);
    ValueTask<CategoryViewModel> UpdateAsync(int id, CategoryUpdateModel categoryUpdate);
}