using Application.Features.Products.Commands;
using FluentValidation;

namespace Application.Features.Products.Validators
{
    internal class CreateProductValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.item.Name)
                .NotEmpty();
            RuleFor(x => x.item.Price)
                .GreaterThan(0);
            When(x => x.item.IsColorApply, () =>
            {
                RuleFor(x => x.item.ProductColor)
                .NotNull()
                .SetValidator(new ProductColorValidator());
            });
        }
    }
}
