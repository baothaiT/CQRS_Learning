using CQRS.Domain.Entities;
using CQRS.Domain.Abstractions.Repository;

namespace CQRS.Application.UserCases.V1.Queries.Product;

public class GetAllProductsQueryHandler
{
    private readonly IProductRepository _repository;

    public GetAllProductsQueryHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<ProductEntity>> Handle(GetAllProductsQuery query)
    {
        return await _repository.GetAllProductsAsync();
    }
}
