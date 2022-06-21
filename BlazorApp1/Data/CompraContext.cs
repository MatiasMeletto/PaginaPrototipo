using BlazorApp1.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class CompraContext : DbContext
    {
        public DbSet<Carrito> Carritos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoProducto> PedidoProductos { get; set; }
        public DbSet<CarritoProducto> CarritoProductos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=compras.db");
    }
}
