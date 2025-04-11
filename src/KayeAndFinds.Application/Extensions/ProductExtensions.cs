namespace KayeAndFinds.Application.Extensions;

public static class ProductExtensions
{
    public static IEnumerable<ProductDto> ToProductDtoList(this IEnumerable<Product> products)
    {
        return products.Select(product => new ProductDto(
            Id: product.Id,
            Name: product.Name,
            ProductCategory: product.ProductCategory,
            Brand: product.Brand,
            Condition: product.Condition,
            Size: product.Size,
            Color: product.Color
            ));
    }

    public static ProductDto ToProductDto(this Product product)
    {
        return DtoFromProduct(product);
    }

    private static ProductDto DtoFromProduct(Product product)
    {
        return new ProductDto(
            Id: product.Id,
            Name: product.Name,
            ProductCategory: product.ProductCategory,
            Brand: product.Brand,
            Condition: product.Condition,
            Size: product.Size,
            Color: product.Color
         );
    }
}
