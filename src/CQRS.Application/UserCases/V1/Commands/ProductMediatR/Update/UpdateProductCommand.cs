using MediatR;
using CQRS.Contract.Share.DTO;

namespace CQRS.Application.UserCases.V1.Commands.ProductMediatR
{
    public class UpdateProductCommand : UpdateProductDto, IRequest
    {
    }
}
