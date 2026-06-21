using Core;

namespace Application.Interfaces.Products
{
    public interface IProductRepository
    {
        Task<int> AddAsync(Product product);
        Task<IList<Product>> GetAllProductsAsync();
    }
}
