using MediatR;
using CQRS.Application.DTO;

namespace CQRS.Application.UserCases.V1.Commands.ProductMediatR
{
    public class UpdateProductCommand : UpdateProductDto, IRequest
    {
    }
}
