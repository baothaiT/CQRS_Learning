using MediatR;

namespace CQRS.API.Commands.ProductMediatR
{
    public class UpdateProductCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
