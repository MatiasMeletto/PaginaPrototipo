using BlazorApp1.Data.Models;

namespace BlazorApp1.Models
{
    public class Choripan
    {
        public int ChoripanId { get; set; }

        public int Criolla { get; set; }
        public int Chimichurri { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }

        public int CarritoId { get; set; }
        public Carrito Carrito { get; set; }
    }
}
