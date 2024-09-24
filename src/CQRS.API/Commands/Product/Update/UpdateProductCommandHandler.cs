using CQRS.API.Repository;

namespace CQRS.API.Commands.Product
{
    public class UpdateProductCommandHandler
    {
        private readonly IProductRepository _repository;

        public UpdateProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateProductCommand command)
        {
            var product = await _repository.GetProductByIdAsync(command.Id);
            if (product != null)
            {
                product.Name = command.Name;
                product.Price = command.Price;
                product.Stock = command.Stock;
                await _repository.UpdateProductAsync(product);
            }
        }
    }
}
