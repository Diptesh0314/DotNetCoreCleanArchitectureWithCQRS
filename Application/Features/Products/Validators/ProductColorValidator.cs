using Core;
using FluentValidation;

namespace Application.Features.Products.Validators
{
    public class ProductColorValidator : AbstractValidator<ProductColor>
    {
        public ProductColorValidator()
        {
            RuleFor(x => x.Code)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Display)
                .NotNull()
                .NotEmpty();
        }
    }
}
