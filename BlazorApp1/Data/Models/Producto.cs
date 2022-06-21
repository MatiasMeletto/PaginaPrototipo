namespace BlazorApp1.Data.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public List<CarritoProducto> Carritos { get; set; } = new();

        public List<PedidoProducto> Pedidos { get; set; } = new();
    }
}
