using CQRS.Contract.Share.DTO;

namespace CQRS.AspNetUI.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<GetProductDto>> GetProductsAsync();
        Task<GetProductDto> GetProductByIdAsync(string id);
        Task CreateProductAsync(CreateProductDto product);
        Task UpdateProductAsync(UpdateProductDto product);
        Task DeleteProductAsync(string id);
    }
}
