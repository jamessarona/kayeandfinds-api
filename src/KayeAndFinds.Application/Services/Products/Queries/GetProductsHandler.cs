using KayeAndFinds.Application.Extensions;

namespace KayeAndFinds.Application.Services.Products.Queries;

public class GetProductsHandler(IApplicationDbContext dbContext)
    : IQueryHandler<GetProductsQuery, GetProductsResult>
{
    public Task<GetProductsResult> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}