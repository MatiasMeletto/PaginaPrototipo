namespace BlazorApp1.Data.Models
{
    public class Empanada
    {
        public int EmpanadaId { get; set; }

        public string _variedad;
        public string Variedad { get => _variedad; set => _variedad = value.ToUpper(); }
        public int Cantidad { get; set; }
        public int Precio { get; set; }

        public int CarritoId { get; set; }
        public Carrito Carrito { get; set; }
    }
}
