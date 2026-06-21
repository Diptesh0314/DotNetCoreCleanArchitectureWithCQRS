using Application.Interfaces.Products;
using Core;

namespace Persistence.Repositories
{
    internal class ProductRepository : IProductRepository
    {
        private IList<Product> products = new List<Product>();
        private async Task<int> AddToProducts(Product item)
        {
            products.Add(item);
            return 1;
        }

        public async Task<int> AddAsync(Product product)
        {
            if (products.Any(x => x.Id == product.Id))
            {
                Console.WriteLine("Product with {0} already exists", product.Id);
                return 0;
            }
            return await AddToProducts(product);
        }

        public async Task<IList<Product>> GetAllProductsAsync()
        {
            products = products ?? [];
            return products;
        }
    }
}
