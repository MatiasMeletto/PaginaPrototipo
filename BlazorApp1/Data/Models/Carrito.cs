namespace BlazorApp1.Data.Models
{
    public class Carrito
    {
        public int CarritoId { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public List<CarritoProducto> Productos { get; set; } = new();
    }
}
