using Microsoft.EntityFrameworkCore;
using Productos.API.Domain;

namespace Productos.API.Infrastructure
{
    public class ProductosDbContext : DbContext
    {
        public ProductosDbContext(DbContextOptions<ProductosDbContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.Property(p => p.Precio)
                      .HasPrecision(18, 2);
            });
        }

    }
}
