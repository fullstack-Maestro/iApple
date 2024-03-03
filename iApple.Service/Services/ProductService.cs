using iApple.Domain.Entities.Product;
using iApple.Service.DTOs.Products;
using iApple.Service.Interfaces;
using iApple.Service.Mappers;

namespace iApple.Service.Services;

public class ProductService : IProductService
{
    /*
    private List<Product> products = new List<Product>();
    ProductReader reader = new ProductReader();
    ProductWriter writer = new ProductWriter();

    public async ValueTask<ProductViewModel> CreateAsync(ProductCreationModel productCreation)
    {
        products = reader.Main();
        var product = Mapper.MapTo<Product>(productCreation);
        product.Id = products.Count == 0 ? 1 : products.Last().Id + 1;
        products.Add(product);
        writer.Main(products);
        return Mapper.MapTo<ProductViewModel>(product);
    }

    public async ValueTask<ProductViewModel> DecrementQuantity(int id, long quantity)
    {
        products = reader.ReadProducts();

        var exist = products.FirstOrDefault(p => p.Id == id);
        if (exist is null)
        {
            throw new Exception("Product is not found");
        }

        exist.UpdatedAt = DateTime.Now;
        exist.Quantity -= quantity;

        writer.WriteProducts(products);

        return Mapper.MapTo<ProductViewModel>(exist);
    }

    public async ValueTask<bool> DeleteAsync(int id)
    {
        products = reader.ReadProducts();

        var exist = products.FirstOrDefault(p => p.Id == id);
        if (exist is null)
        {
            throw new Exception("Product is not found");
        }

        exist.DeletedAt = DateTime.Now;
        exist.IsDeleted = true;

        writer.WriteProducts(products);

        return true;
    }

    public async ValueTask<List<ProductViewModel>> GetAllByCategoryAsync(string category)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<List<ProductViewModel>> GetAllByPriceRangeAsync(decimal minPrice, decimal maxPrice)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<List<ProductViewModel>> GetAllProductsAsync()
    {
        products = reader.Main();
        return Mapper.MapTo<ProductViewModel>(products);
    }

    public async ValueTask<ProductViewModel> GetByIdAsync(int id)
    {
        products = reader.Main();
        var exist = products.FirstOrDefault(x => x.Id == id);
        if (exist is null)
        {
            throw new Exception("Product is not found");
        }
        return Mapper.MapTo<ProductViewModel>(exist);
    }

    public async ValueTask<ProductViewModel> IncrementQuantity(int id, long quantity)
    {
        products = reader.ReadProducts();

        var exist = products.FirstOrDefault(p => p.Id == id);
        if (exist is null)
        {
            throw new Exception("Product is not found");
        }

        exist.UpdatedAt = DateTime.Now;
        exist.Quantity += quantity;

        writer.WriteProducts(products);

        return Mapper.MapTo<ProductViewModel>(exist);
    }

    public async ValueTask<List<ProductViewModel>> SearchByName(string name)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<ProductViewModel> UpdateAsync(int id, ProductUpdateModel productUpdate)
    {
        products = reader.ReadProducts();

        var exist = products.FirstOrDefault(p => p.Id == id);
        if (exist is null)
        {
            throw new Exception("Product is not found");
        }

        exist.UpdatedAt = DateTime.Now;
        exist.Description = productUpdate.Description;
        exist.Name = productUpdate.Name;
        exist.Storage = productUpdate.Storage;

        writer.WriteProducts(products);

        return Mapper.MapTo<ProductViewModel>(exist);
    }

    public async ValueTask<ProductViewModel> UpdatePrice(int id, decimal price)
    {
        products = reader.ReadProducts();
        var exist = products.FirstOrDefault(p => p.Id == id);
        if (exist is null)
        {
            throw new Exception("Product is not found");
        }
        exist.UpdatedAt = DateTime.Now;
        exist.Price = price;

        writer.WriteProducts(products);

        return Mapper.MapTo<ProductViewModel>(exist);
    }
    */
    public ValueTask<ProductViewModel> CreateAsync(ProductCreationModel productCreation)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ProductViewModel> DecrementQuantity(int id, long quantity)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<List<ProductViewModel>> GetAllByCategoryAsync(string category)
    {
        throw new NotImplementedException();
    }

    public ValueTask<List<ProductViewModel>> GetAllByPriceRangeAsync(decimal minPrice, decimal maxPrice)
    {
        throw new NotImplementedException();
    }

    public ValueTask<List<ProductViewModel>> GetAllProductsAsync()
    {
        throw new NotImplementedException();
    }

    public ValueTask<ProductViewModel> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ProductViewModel> IncrementQuantity(int id, long quantity)
    {
        throw new NotImplementedException();
    }

    public ValueTask<List<ProductViewModel>> SearchByName(string name)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ProductViewModel> UpdateAsync(int id, ProductUpdateModel productUpdate)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ProductViewModel> UpdatePrice(int id, decimal price)
    {
        throw new NotImplementedException();
    }
}