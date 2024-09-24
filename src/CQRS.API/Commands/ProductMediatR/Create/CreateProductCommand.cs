using CQRS.API.DTO;
using MediatR;

namespace CQRS.API.Commands.ProductMediatR
{
    public class CreateProductCommand : CreateProductDto, IRequest<Models.Product>
    {
    }
}
