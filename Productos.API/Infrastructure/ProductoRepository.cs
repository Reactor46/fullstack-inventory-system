using Microsoft.EntityFrameworkCore;
using Productos.API.Application;
using Productos.API.Domain;
// using Productos.API.Infrastructure;

namespace Productos.API.Infrastructure;

public class ProductoRepository : IProductoRepository
{
    private readonly ProductosDbContext _context;
    public ProductoRepository(ProductosDbContext context) => _context = context;

    public async Task AddAsync(Producto producto)
    {
        _context.Productos.Add(producto);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var p = await _context.Productos.FindAsync(id);
        if (p != null)
        {
            _context.Productos.Remove(p);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Producto>> GetAllAsync() => await _context.Productos.ToListAsync();

    public async Task<Producto?> GetByIdAsync(int id) => await _context.Productos.FindAsync(id);

    public async Task UpdateAsync(Producto producto)
    {
        _context.Entry(producto).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
