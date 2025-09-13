namespace Transacciones.API.Application.DTOs
{
    public class TransaccionDTO
    {
        public string Tipo { get; set; } = null!;
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string? Detalle { get; set; }
    }
}
