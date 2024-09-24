using CQRS.Domain.Abstractions.Repository;

namespace CQRS.Application.UserCases.V1.Commands.Product;

public class DeleteProductCommandHandler
{
    private readonly IProductRepository _repository;

    public DeleteProductCommandHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteProductCommand command)
    {
        await _repository.DeleteProductAsync(command.Id);
    }
}
