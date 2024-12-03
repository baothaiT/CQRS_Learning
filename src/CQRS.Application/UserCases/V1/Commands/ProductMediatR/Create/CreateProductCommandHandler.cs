using CQRS.Domain.Abstractions.Repository;
using CQRS.Domain.Entities;
using MediatR;

namespace CQRS.Application.UserCases.V1.Commands.ProductMediatR;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductEntity>
{
    private readonly IProductRepository _repository;

    public CreateProductCommandHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<ProductEntity> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        var product = new ProductEntity
        {
            Id = Guid.NewGuid(),
            Name = command.Name,
            Price = command.Price,
            Stock = command.Stock
        };

        await _repository.AddProductAsync(product);
        return product;
    }
}
