namespace BlazorApp1.Data.Models
{
    public class Adicional
    {
        public int AdicionalId { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
    }
}
