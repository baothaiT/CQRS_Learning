using CQRS.Domain.Abstractions.Repository;
using CQRS.Domain.Entities;

namespace CQRS.Application.UserCases.V1.Queries.Product;

public class GetProductByIdQueryHandler
{
    private readonly IProductRepository _repository;

    public GetProductByIdQueryHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<ProductEntity> Handle(GetProductByIdQuery query)
    {
        return await _repository.GetProductByIdAsync(query.Id);
    }
}
