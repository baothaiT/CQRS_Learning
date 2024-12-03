using CQRS.Domain.Entities;

namespace CQRS.Domain.Abstractions.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductEntity>> GetAllProductsAsync();
        Task<ProductEntity> GetProductByIdAsync(Guid id);
        Task AddProductAsync(ProductEntity product);
        Task UpdateProductAsync(ProductEntity product);
        Task DeleteProductAsync(Guid id);
    }
}
