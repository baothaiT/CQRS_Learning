using CQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<ProductEntity> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Optionally configure entity mappings here if needed
        // e.g., modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired();
    }
}
