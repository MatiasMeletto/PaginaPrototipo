namespace BlazorApp1.Data.Models
{
    public class CarritoProducto
    {
        public int CarritoProductoId { get; set; } 
        
        public int CarritoId { get; set; }
        public Carrito Carrito { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

        public List<CarritoProductoAdicional> Adicionales { get; set; }
    }
}
