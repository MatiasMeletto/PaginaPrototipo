using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Data.Migrations
{
    public partial class AdicionalesHamburguesa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 4, 4, "Hamburguesa", 0 });

            migrationBuilder.InsertData(
                table: "Adicionales",
                columns: new[] { "AdicionalId", "Nombre", "Precio", "ProductoId" },
                values: new object[] { 3, "Pan", 50, 4 });

            migrationBuilder.InsertData(
                table: "Adicionales",
                columns: new[] { "AdicionalId", "Nombre", "Precio", "ProductoId" },
                values: new object[] { 4, "Carne", 100, 4 });

            migrationBuilder.InsertData(
                table: "Adicionales",
                columns: new[] { "AdicionalId", "Nombre", "Precio", "ProductoId" },
                values: new object[] { 5, "Lechuga", 42, 4 });

            migrationBuilder.InsertData(
                table: "Adicionales",
                columns: new[] { "AdicionalId", "Nombre", "Precio", "ProductoId" },
                values: new object[] { 6, "Tomate", 37, 4 });

            migrationBuilder.InsertData(
                table: "Adicionales",
                columns: new[] { "AdicionalId", "Nombre", "Precio", "ProductoId" },
                values: new object[] { 7, "Huevo", 68, 4 });

            migrationBuilder.InsertData(
                table: "Adicionales",
                columns: new[] { "AdicionalId", "Nombre", "Precio", "ProductoId" },
                values: new object[] { 8, "Bacon", 53, 4 });

            migrationBuilder.InsertData(
                table: "Adicionales",
                columns: new[] { "AdicionalId", "Nombre", "Precio", "ProductoId" },
                values: new object[] { 9, "Cheddar", 49, 4 });

            migrationBuilder.InsertData(
                table: "Adicionales",
                columns: new[] { "AdicionalId", "Nombre", "Precio", "ProductoId" },
                values: new object[] { 10, "Tybo", 41, 4 });

            migrationBuilder.InsertData(
                table: "Adicionales",
                columns: new[] { "AdicionalId", "Nombre", "Precio", "ProductoId" },
                values: new object[] { 11, "Jamon", 40, 4 });

            migrationBuilder.InsertData(
                table: "Adicionales",
                columns: new[] { "AdicionalId", "Nombre", "Precio", "ProductoId" },
                values: new object[] { 12, "Cebolla", 67, 4 });

            migrationBuilder.InsertData(
                table: "Adicionales",
                columns: new[] { "AdicionalId", "Nombre", "Precio", "ProductoId" },
                values: new object[] { 13, "Mayonesa", 36, 4 });

            migrationBuilder.InsertData(
                table: "Adicionales",
                columns: new[] { "AdicionalId", "Nombre", "Precio", "ProductoId" },
                values: new object[] { 14, "Ketchup", 33, 4 });

            migrationBuilder.InsertData(
                table: "Adicionales",
                columns: new[] { "AdicionalId", "Nombre", "Precio", "ProductoId" },
                values: new object[] { 15, "Mostaza", 24, 4 });

            migrationBuilder.InsertData(
                table: "Adicionales",
                columns: new[] { "AdicionalId", "Nombre", "Precio", "ProductoId" },
                values: new object[] { 16, "Sabora", 26, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Adicionales",
                keyColumn: "AdicionalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Adicionales",
                keyColumn: "AdicionalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Adicionales",
                keyColumn: "AdicionalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Adicionales",
                keyColumn: "AdicionalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Adicionales",
                keyColumn: "AdicionalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Adicionales",
                keyColumn: "AdicionalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Adicionales",
                keyColumn: "AdicionalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Adicionales",
                keyColumn: "AdicionalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Adicionales",
                keyColumn: "AdicionalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Adicionales",
                keyColumn: "AdicionalId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Adicionales",
                keyColumn: "AdicionalId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Adicionales",
                keyColumn: "AdicionalId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Adicionales",
                keyColumn: "AdicionalId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Adicionales",
                keyColumn: "AdicionalId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4);
        }
    }
}
