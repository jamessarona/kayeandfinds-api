
namespace KayeAndFinds.Application.Services.Products.Commands.CreateProduct;

public class CreateProductHandler
    (IApplicationDbContext dbContext)
    : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        var product = CreateNewProduct(command.Product);

        dbContext.Products.Add(product);
        await dbContext.SaveChangesAsync(cancellationToken);

        return new CreateProductResult(product.Id);
    }

    private Product CreateNewProduct(ProductDto productDto)
    {
        var newProduct = Product.Create(
            id: Guid.NewGuid(),
            name: productDto.Name,
            productCategory: productDto.ProductCategory,
            brand: productDto.Brand,
            condition: productDto.Condition,
            size: productDto.Size,
            color: productDto.Color
        );

        return newProduct;
    }
}
