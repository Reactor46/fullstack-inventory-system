using Transacciones.API.Application.DTOs;
using Transacciones.API.Application.Interfaces;
using Transacciones.API.Domain;

namespace Transacciones.API.Application.Services
{
    public class TransaccionService
    {
        private readonly ITransaccionRepository _repository;

        public TransaccionService(ITransaccionRepository repository)
        {
            _repository = repository;
        }

        public async Task<Transaccion> CrearTransaccionAsync(Transaccion dto)
        {
            var transaccion = new Transaccion(dto.ProductoId, dto.Tipo, dto.Cantidad, dto.PrecioUnitario, dto.Detalle);
            return await _repository.AddAsync(transaccion);
        }

        public async Task<IEnumerable<Transaccion>> ListarTransaccionesAsync(int pageNumber, int pageSize, string? tipo = null, int? productoId = null, DateTime? desde = null, DateTime? hasta = null)
        {
            return await _repository.GetAllAsync(pageNumber, pageSize, tipo, productoId, desde, hasta);
        }

        public async Task<Transaccion?> ObtenerPorIdAsync(int id) => await _repository.GetByIdAsync(id);
    }
}
