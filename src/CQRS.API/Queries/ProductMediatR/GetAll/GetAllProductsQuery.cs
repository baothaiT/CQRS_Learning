using MediatR;

namespace CQRS.API.Queries.ProductMediatR
{
    public class GetAllProductsQuery : IRequest<IEnumerable<Models.Product>>
    {
    }
}
