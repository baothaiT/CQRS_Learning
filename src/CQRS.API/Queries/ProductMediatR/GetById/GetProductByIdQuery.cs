using MediatR;

namespace CQRS.API.Queries.ProductMediatR
{
    public class GetProductByIdQuery : IRequest<Models.Product>
    {
        public Guid Id { get; set; }
    }
}
