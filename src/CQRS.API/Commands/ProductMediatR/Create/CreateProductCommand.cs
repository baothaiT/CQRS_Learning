using MediatR;

namespace CQRS.API.Commands.ProductMediatR
{
    public class CreateProductCommand : IRequest<Models.Product>
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
