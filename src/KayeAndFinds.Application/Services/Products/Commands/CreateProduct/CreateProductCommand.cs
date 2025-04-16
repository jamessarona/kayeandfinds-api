using FluentValidation;

namespace KayeAndFinds.Application.Services.Products.Commands.CreateProduct;

public record CreateProductCommand(ProductDto Product)
    : ICommand<CreateProductResult>;

public record CreateProductResult(Guid Id);

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(x => x.Product.Name).NotEmpty().WithMessage("Name is required");
        RuleFor(x => x.Product.ProductCategory).NotEmpty().WithMessage("Category is required");
        RuleFor(x => x.Product.Brand).NotEmpty().WithMessage("Name is required");
        RuleFor(x => x.Product.Condition).NotEmpty().WithMessage("Condition is required");
        RuleFor(x => x.Product.Size).NotEmpty().WithMessage("Size is required");
        RuleFor(x => x.Product.Condition).NotEmpty().WithMessage("Color is required");
    }
}