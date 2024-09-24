using CQRS.API.Models;
using CQRS.API.Repository;

namespace CQRS.API.Queries.Product
{
    public class GetAllProductsQueryHandler
    {
        private readonly IProductRepository _repository;

        public GetAllProductsQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Models.Product>> Handle(GetAllProductsQuery query)
        {
            return await _repository.GetAllProductsAsync();
        }
    }
}
