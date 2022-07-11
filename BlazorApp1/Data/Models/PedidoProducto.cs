namespace BlazorApp1.Data.Models
{
    public class PedidoProducto
    {
        public int PedidoProductoId { get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }

        public List<PedidoProductoAdicional> Adicionales { get; set; }
    }
}
