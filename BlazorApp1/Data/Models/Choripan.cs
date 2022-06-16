using BlazorApp1.Data.Models;

namespace BlazorApp1.Models
{
    public class Choripan
    {
        public int ChoripanId { get; set; }

        public int Criolla { get; set; }
        public int Chimichurri { get; set; }
        public int Cantidad { get; set; }

        public const int Precio = 100;

        public Choripan(int criolla, int chimichurri, int cantidad)
        {
            Criolla = criolla;
            Chimichurri = chimichurri;
            Cantidad = cantidad;
        }

        public int CarritoId { get; set; }
        public Carrito Carrito { get; set; }
    }
}
