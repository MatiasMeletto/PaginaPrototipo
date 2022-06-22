namespace BlazorApp1.Data.Models
{
    public class CarritoProductoAdicional
    {
        public int CarritoProductoAdicionalId { get; set; }
        public int CarritoProductoId { get; set; }
        public CarritoProducto CarritoProducto { get; set; }
        public int AdicionalId { get; set; }
        public Adicional Adicional { get; set; }
        public int Cantidad { get; set; }
    }
}
