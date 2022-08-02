namespace BlazorApp1.Data.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }

        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public List<PedidoProducto> Productos { get; set; } = new();
    }
}
