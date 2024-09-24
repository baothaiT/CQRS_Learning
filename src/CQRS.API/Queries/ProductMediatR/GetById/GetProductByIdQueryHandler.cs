using CQRS.API.Repository;
using MediatR;

namespace CQRS.API.Queries.ProductMediatR
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Models.Product>
    {
        private readonly IProductRepository _repository;

        public GetProductByIdQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Models.Product> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
        {
            return await _repository.GetProductByIdAsync(query.Id);
        }
    }
}
