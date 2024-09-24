using CQRS.API.Repository;
using MediatR;

namespace CQRS.API.Queries.ProductMediatR
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Models.Product>>
    {
        private readonly IProductRepository _repository;

        public GetAllProductsQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Models.Product>> Handle(GetAllProductsQuery query, CancellationToken cancellationToken)
        {
            return await _repository.GetAllProductsAsync();
        }
    }
}
