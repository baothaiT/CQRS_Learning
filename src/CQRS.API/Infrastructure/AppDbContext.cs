using CQRS.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS.API.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Optionally configure entity mappings here if needed
            // e.g., modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired();
        }
    }
}
