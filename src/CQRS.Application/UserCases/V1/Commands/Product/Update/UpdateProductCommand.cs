namespace CQRS.Application.UserCases.V1.Commands.Product;

public class UpdateProductCommand
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}
