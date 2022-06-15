namespace BlazorApp1.Data.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }

        public string _variedad;
        public string Variedad { get => _variedad; set => _variedad = value.ToUpper(); }
        public int Cantidad { get; set; }
        public int Precio { get; set; }

        public int CarritoId { get; set; }
        public Carrito Carrito { get; set; }
    }
}
