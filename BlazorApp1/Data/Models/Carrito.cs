using BlazorApp1.Models;

namespace BlazorApp1.Data.Models
{
    public class Carrito
    {
        public int CarritoId = 0;
        public List<Bebida> BebidasC { get; } = new();
        public List<Choripan> ChoripanesC { get; } = new();
        public List<Empanada> EmpanadasC { get; } = new();
        public List<HamburguesaCant> Hamburguesas { get; } = new();
        public List<Pizza> Pizzas { get; } = new();
        public List<Torta> Tortas { get; } = new();
    }
}
