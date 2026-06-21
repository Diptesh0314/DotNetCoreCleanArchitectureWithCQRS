using Application.Interfaces.Products;
using Core;
using MediatR;

namespace Application.Features.Products.Queries
{
    internal class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, IList<Product>>
    {
        private readonly IProductRepository _productRepo;
        public GetAllProductsHandler(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task<IList<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _productRepo.GetAllProductsAsync();
        }
    }
}
