using MediatR;
using CQRS.API.DTO;

namespace CQRS.API.Commands.ProductMediatR
{
    public class UpdateProductCommand : UpdateProductDto, IRequest
    {
    }
}
