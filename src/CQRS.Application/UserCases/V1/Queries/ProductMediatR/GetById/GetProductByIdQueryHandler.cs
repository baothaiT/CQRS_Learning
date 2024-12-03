using CQRS.Domain.Abstractions.Repository;
using MediatR;
using CQRS.Domain.Entities;

namespace CQRS.Application.UserCases.V1.Queries.ProductMediatR;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductEntity>
{
    private readonly IProductRepository _repository;

    public GetProductByIdQueryHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<ProductEntity> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
    {
        return await _repository.GetProductByIdAsync(query.Id);
    }
}
