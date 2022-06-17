namespace BlazorApp1.Data.Models
{
    public class HamburguesaCant
    {
        public int HamburguesaCantId { get; set; }
        public int Pan { get; set; }
        public int Carne { get; set; }
        public int Lechuga { get; set; }
        public int Tomate { get; set; }
        public int Huevo { get; set; }
        public int Bacon { get; set; }
        public int Cheddar { get; set; }
        public int Tybo { get; set; }
        public int Jamon { get; set; }
        public int Cebolla { get; set; }
        public int Mayonesa { get; set; }
        public int Ketchup { get; set; }
        public int Mostaza { get; set; }
        public int Sabora { get; set; }
        public int Precio { get; set; }

        public int CarritoId { get; set; }
        public Carrito Carrito { get; set; }
    }
}
