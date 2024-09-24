using CQRS.Domain.Abstractions.Repository;
using MediatR;

namespace CQRS.Application.UserCases.V1.Commands.ProductMediatR
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IProductRepository _repository;

        public UpdateProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
        {
            var product = await _repository.GetProductByIdAsync(command.Id);
            if (product != null)
            {
                product.Name = command.Name;
                //product.Price = command.Price;
                product.Stock = command.Stock;
                await _repository.UpdateProductAsync(product);
            }
            return Unit.Value;
        }
    }
}
