using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Data.Migrations
{
    public partial class CorrecionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tomate",
                table: "Pizzas",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "Lechuga",
                table: "Pizzas",
                newName: "Cantidad");

            migrationBuilder.RenameColumn(
                name: "Tomate",
                table: "Empanadas",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "Lechuga",
                table: "Empanadas",
                newName: "Cantidad");

            migrationBuilder.RenameColumn(
                name: "Tomate",
                table: "Bebidas",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "Lechuga",
                table: "Bebidas",
                newName: "Cantidad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "Pizzas",
                newName: "Tomate");

            migrationBuilder.RenameColumn(
                name: "Cantidad",
                table: "Pizzas",
                newName: "Lechuga");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "Empanadas",
                newName: "Tomate");

            migrationBuilder.RenameColumn(
                name: "Cantidad",
                table: "Empanadas",
                newName: "Lechuga");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "Bebidas",
                newName: "Tomate");

            migrationBuilder.RenameColumn(
                name: "Cantidad",
                table: "Bebidas",
                newName: "Lechuga");
        }
    }
}
