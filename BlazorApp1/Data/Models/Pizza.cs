namespace BlazorApp1.Data.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }

        public string _variedad;
        public string Variedad { get => _variedad; set => _variedad = value.ToUpper(); }
        public int Lechuga { get; set; }
        public int Tomate { get; set; }

        public int CarritoId { get; set; }
        public Carrito Carrito { get; set; }
    }
}
