using iApple.Service.DTOs.Products;

namespace iApple.Service.Interfaces;

public interface IProductService
{
    ValueTask<bool> DeleteAsync(int id);
    ValueTask<ProductViewModel> GetByIdAsync(int id);
    ValueTask<List<ProductViewModel>> GetAllProductsAsync(); // later add pagination
    ValueTask<List<ProductViewModel>> SearchByName(string name);
    ValueTask<ProductViewModel> UpdatePrice(int id, decimal price);
    ValueTask<ProductViewModel> IncrementQuantity(int id, long quantity);
    ValueTask<ProductViewModel> DecrementQuantity(int id, long quantity);
    ValueTask<List<ProductViewModel>> GetAllByCategoryAsync(string category);
    ValueTask<ProductViewModel> CreateAsync(ProductCreationModel productCreation);
    ValueTask<ProductViewModel> UpdateAsync(int id, ProductUpdateModel productUpdate);
    ValueTask<List<ProductViewModel>> GetAllByPriceRangeAsync(decimal minPrice, decimal maxPrice);
}