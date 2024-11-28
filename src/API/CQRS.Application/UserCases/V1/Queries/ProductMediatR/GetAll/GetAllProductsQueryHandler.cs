using CQRS.Domain.Abstractions.Repository;
using CQRS.Domain.Entities;
using MediatR;

namespace CQRS.Application.UserCases.V1.Queries.ProductMediatR;

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<ProductEntity>>
{
    private readonly IProductRepository _repository;

    public GetAllProductsQueryHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<ProductEntity>> Handle(GetAllProductsQuery query, CancellationToken cancellationToken)
    {
        return await _repository.GetAllProductsAsync();
    }
}

