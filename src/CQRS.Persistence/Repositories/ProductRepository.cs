using CQRS.Domain.Entities;
using System;
using Microsoft.EntityFrameworkCore;
using CQRS.Domain.Abstractions.Repository;


namespace CQRS.Persistence.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductEntity>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<ProductEntity> GetProductByIdAsync(Guid id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task AddProductAsync(ProductEntity product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(ProductEntity product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(Guid id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }
    }
}
