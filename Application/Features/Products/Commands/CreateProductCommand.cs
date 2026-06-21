using Core;
using MediatR;

namespace Application.Features.Products.Commands
{
    public record CreateProductCommand(Product item) : IRequest<Guid>;
}
