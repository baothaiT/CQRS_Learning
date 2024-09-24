using CQRS.Domain.Entities;
using CQRS.Domain.Abstractions.Repository;

namespace CQRS.Application.UserCases.V1.Commands.Product;

public class CreateProductCommandHandler
{
    private readonly IProductRepository _repository;

    public CreateProductCommandHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateProductCommand command)
    {
        var product = new ProductEntity
        {
            Id = Guid.NewGuid(),
            Name = command.Name,
            Price = command.Price,
            Stock = command.Stock
        };

        await _repository.AddProductAsync(product);
    }
}
