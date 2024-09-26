using MediatR;

namespace CQRS.Application.UserCases.V1.Commands.ProductMediatR;

public class DeleteProductCommand : IRequest
{
    public Guid Id { get; set; }
}
