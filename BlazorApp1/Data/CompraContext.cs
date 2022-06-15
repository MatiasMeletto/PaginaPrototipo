using BlazorApp1.Data.Models;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class CompraContext : DbContext
    {
        public DbSet<Bebida> Bebidas { get; set; }
        public DbSet<Choripan> Choripanes { get; set; }
        public DbSet<Empanada> Empanadas { get; set; }
        public DbSet<HamburguesaCant> hamburguesaCantidades { get; set; }
        public DbSet<HamburguesaPrecio> HamburguesaPrecios { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Torta> Tortas { get; set; }

        public string DbPath { get; }

        public CompraContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "blogging.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
