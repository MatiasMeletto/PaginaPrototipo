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
                },
                new Producto()
                {
                    ProductoId = 4,
                    CategoriaId = 4,
                    Nombre = "Hamburguesa",
                    Precio = 0
                });
                new Producto()
                {
                    ProductoId = 4,
                    CategoriaId = 4,
                    Nombre = "Hamburguesa",
                    Precio = 0
                };

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
                },
                new Adicional()
                {
                    AdicionalId = 3,
                    Nombre = "Pan",
                    Precio = 50,
                    ProductoId = 4
                },
                new Adicional()
                {
                    AdicionalId = 4,
                    Nombre = "Carne",
                    Precio = 100,
                    ProductoId = 4
                },
                new Adicional()
                {
                    AdicionalId = 5,
                    Nombre = "Lechuga",
                    Precio = 42,
                    ProductoId = 4
                },
                new Adicional()
                {
                    AdicionalId = 6,
                    Nombre = "Tomate",
                    Precio = 37,
                    ProductoId = 4

                },
                new Adicional()
                {
                    AdicionalId = 7,
                    Nombre = "Huevo",
                    Precio = 68,
                    ProductoId = 4
                }, 
                new Adicional()
                {
                    AdicionalId = 8,
                    Nombre = "Bacon",
                    Precio = 53,
                    ProductoId = 4
                },
                new Adicional()
                {
                    AdicionalId = 9,
                    Nombre = "Cheddar",
                    Precio = 49,
                    ProductoId = 4
                }, 
                new Adicional()
                {
                    AdicionalId = 10,
                    Nombre = "Tybo",
                    Precio = 41,
                    ProductoId = 4
                },
                new Adicional()
                {
                    AdicionalId = 11,
                    Nombre = "Jamon",
                    Precio = 40,
                    ProductoId = 4
                },
                new Adicional()
                {
                    AdicionalId = 12,
                    Nombre = "Cebolla",
                    Precio = 67,
                    ProductoId = 4
                },
                new Adicional()
                {
                    AdicionalId = 13,
                    Nombre = "Mayonesa",
                    Precio = 36,
                    ProductoId = 4
                },
                new Adicional()
                {
                    AdicionalId = 14,
                    Nombre = "Ketchup",
                    Precio = 33,
                    ProductoId = 4
                },
                new Adicional()
                {
                    AdicionalId = 15,
                    Nombre = "Mostaza",
                    Precio = 24,
                    ProductoId = 4
                },
                new Adicional()
                {
                    AdicionalId = 16,
                    Nombre = "Sabora",
                    Precio = 26,
                    ProductoId = 4
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
