namespace KayeAndFinds.Application.Services.Products.Queries;

public record GetProductsQuery(PaginationRequest PaginationRequest)
    : IQuery<GetProductsResult>;

public record GetProductsResult(PaginatedResult<ProductDto> Products);