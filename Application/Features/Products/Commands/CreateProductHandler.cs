using Application.Interfaces.Products;
using Core;
using MediatR;

namespace Application.Features.Products.Commands
{
    public class CreateProductHandler
    : IRequestHandler<CreateProductCommand, Guid>
    {
        private readonly IProductRepository _repository;

        public CreateProductHandler(
            IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(
            CreateProductCommand request,
            CancellationToken ct)
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = request.item.Name,
                Price = request.item.Price
            };

            await _repository.AddAsync(product);

            return product.Id;
        }
    }
}
