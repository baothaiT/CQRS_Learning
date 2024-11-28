using MediatR;
using CQRS.Domain.Entities;

namespace CQRS.Application.UserCases.V1.Queries.ProductMediatR;

public class GetAllProductsQuery : IRequest<IEnumerable<ProductEntity>>
{
}
