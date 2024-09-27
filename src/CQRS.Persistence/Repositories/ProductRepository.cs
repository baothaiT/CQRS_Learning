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
            return await _context.ProductsTable.ToListAsync();
        }

        public async Task<ProductEntity> GetProductByIdAsync(Guid id)
        {
            return await _context.ProductsTable.FindAsync(id);
        }

        public async Task AddProductAsync(ProductEntity product)
        {
            await _context.ProductsTable.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(ProductEntity product)
        {
            _context.ProductsTable.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(Guid id)
        {
            var product = await _context.ProductsTable.FindAsync(id);
            if (product != null)
            {
                _context.ProductsTable.Remove(product);
                await _context.SaveChangesAsync();
            }
        }
    }
}
