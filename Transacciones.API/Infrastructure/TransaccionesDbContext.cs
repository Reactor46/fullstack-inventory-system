using Microsoft.EntityFrameworkCore;
using Transacciones.API.Domain;

namespace Transacciones.API.Infrastructure
{
    public class TransaccionesDbContext : DbContext
    {
        public TransaccionesDbContext(DbContextOptions<TransaccionesDbContext> options) : base(options) { }

        public DbSet<Transaccion> Transacciones { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaccion>(entity =>
            {
                entity.Property(t => t.PrecioUnitario).HasPrecision(18, 2);
                entity.Property(t => t.PrecioTotal).HasPrecision(18, 2);
            });
        }
    }
}
