namespace BlazorApp1.Data.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string  Nombre { get; set; }

        public List<Producto> Productos { get; set; } = new();
    }
}
