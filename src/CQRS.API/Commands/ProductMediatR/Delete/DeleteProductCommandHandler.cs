using CQRS.API.Repository;
using MediatR;

namespace CQRS.API.Commands.ProductMediatR
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IProductRepository _repository;

        public DeleteProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteProductCommand command, CancellationToken cancellationToken)
        {
            await _repository.DeleteProductAsync(command.Id);
            return Unit.Value;
        }

        //async Task IRequestHandler<DeleteProductCommand>.Handle(DeleteProductCommand command, CancellationToken cancellationToken)
        //{
        //    await _repository.DeleteProductAsync(command.Id);
        //}
    }
}
