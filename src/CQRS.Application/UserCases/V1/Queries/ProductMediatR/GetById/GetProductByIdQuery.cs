using MediatR;
using CQRS.Domain.Entities;

namespace CQRS.Application.UserCases.V1.Queries.ProductMediatR;

public class GetProductByIdQuery : IRequest<ProductEntity>
{
    public Guid Id { get; set; }
}
