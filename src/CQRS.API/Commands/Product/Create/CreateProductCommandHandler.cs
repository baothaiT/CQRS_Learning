using CQRS.API.Models;
using CQRS.API.Repository;

namespace CQRS.API.Commands.Product
{
    public class CreateProductCommandHandler
    {
        private readonly IProductRepository _repository;

        public CreateProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateProductCommand command)
        {
            var product = new Models.Product
            {
                Id = Guid.NewGuid(),
                Name = command.Name,
                Price = command.Price,
                Stock = command.Stock
            };

            await _repository.AddProductAsync(product);
        }
    }
}
