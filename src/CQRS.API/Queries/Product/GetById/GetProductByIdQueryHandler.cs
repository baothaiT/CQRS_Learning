using CQRS.API.Repository;

namespace CQRS.API.Queries.Product
{
    public class GetProductByIdQueryHandler
    {
        private readonly IProductRepository _repository;

        public GetProductByIdQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Models.Product> Handle(GetProductByIdQuery query)
        {
            return await _repository.GetProductByIdAsync(query.Id);
        }
    }
}
