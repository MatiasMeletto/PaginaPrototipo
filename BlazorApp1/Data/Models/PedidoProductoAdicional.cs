namespace BlazorApp1.Data.Models
{
    public class PedidoProductoAdicional
    {
        public int PedidoProductoAdicionalId { get; set; }
        public int PedidoProductoId { get; set; }
        public PedidoProducto PedidoProducto { get; set; }
        public int AdicionalId { get; set; }
        public Adicional Adicional { get; set; }
        public int Cantidad { get; set; }
    }
}
