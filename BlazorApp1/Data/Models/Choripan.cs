namespace BlazorApp1.Data.Models
{
    public class Choripan
    {
        public int ChoripanId { get; set; }

        public bool Criolla { get; set; }
        public bool Chimichurri { get; set; }
        public int Cantidad { get; set; }

        public const int Precio = 100;

        public int CarritoId { get; set; }
        public Carrito Carrito { get; set; }
    }
}
