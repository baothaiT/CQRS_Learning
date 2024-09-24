using CQRS.API.Repository;
using MediatR;

namespace CQRS.API.Commands.ProductMediatR
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Models.Product>
    {
        private readonly IProductRepository _repository;

        public CreateProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Models.Product> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var product = new Models.Product
            {
                Id = Guid.NewGuid(),
                Name = command.Name,
                Price = command.Price,
                Stock = command.Stock
            };

            await _repository.AddProductAsync(product);
            return product; // Return the created product ID
        }
    }
}
