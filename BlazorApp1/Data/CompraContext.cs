using BlazorApp1.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class CompraContext : DbContext
    {
        public DbSet<Adicional> Adicionales { get; set; }
        public DbSet<Carrito> Carritos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoProducto> PedidoProductos { get; set; }
        public DbSet<CarritoProducto> CarritoProductos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=compras.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .HasData(new Categoria 
                { 
                    CategoriaId = 1,
                    Nombre = "Choripan"
                },
                new Categoria
                {
                    CategoriaId = 2,
                    Nombre = "Pizza"
                },
                new Categoria
                {
                    CategoriaId = 3,
                    Nombre = "Torta"
                },
                new Categoria
                {
                    CategoriaId = 4,
                    Nombre = "Hamburguesa"
                },
                new Categoria
                {
                    CategoriaId = 5,
                    Nombre = "Empanada"
                },
                new Categoria
                {
                    CategoriaId = 6,
                    Nombre = "Bebida"
                });

            modelBuilder.Entity<Producto>()
                .HasData(new Producto()
                {
                    ProductoId = 1,
                    CategoriaId = 1,
                    Nombre = "Choripan",
                    Precio = 100
                });

            modelBuilder.Entity<Adicional>()
                .HasData(new Adicional()
                {
                    AdicionalId = 1,
                    Nombre = "Salsa criolla",
                    Precio = 0,
                    ProductoId = 1
                },
                new Adicional()
                {
                    AdicionalId = 2,
                    Nombre = "Chimichurri",
                    Precio = 0,
                    ProductoId = 1
                });

            modelBuilder.Entity<Usuario>()
                .HasData(new Usuario()
                {
                    UsuarioId = 1,
                    Nombre = "guest",
                    Password = "password"
                });

            modelBuilder.Entity<Carrito>()
                .HasData(new Carrito() 
                {
                    CarritoId = 1,
                    UsuarioId = 1
                });
        }
    }
}
