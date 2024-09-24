using MediatR;

namespace CQRS.API.Commands.ProductMediatR
{
    public class DeleteProductCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
