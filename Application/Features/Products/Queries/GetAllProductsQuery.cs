using Core;
using MediatR;

namespace Application.Features.Products.Queries
{
    public record GetAllProductsQuery : IRequest<IList<Product>>;
}
