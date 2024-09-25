using CQRS.Contract.Share.DTO;
using CQRS.Domain.Entities;
using MediatR;

namespace CQRS.Application.UserCases.V1.Commands.ProductMediatR
{
    public class CreateProductCommand : CreateProductDto, IRequest<ProductEntity>
    {
    }
}
