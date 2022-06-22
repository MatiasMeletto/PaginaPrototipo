using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Data.Migrations
{
    public partial class Adicionales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProductos_Pedidos_PedidoId1",
                table: "PedidoProductos");

            migrationBuilder.RenameColumn(
                name: "PedidoId1",
                table: "PedidoProductos",
                newName: "PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoProductos_PedidoId1",
                table: "PedidoProductos",
                newName: "IX_PedidoProductos_PedidoId");

            migrationBuilder.CreateTable(
                name: "Adicional",
                columns: table => new
                {
                    AdicionalId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Precio = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adicional", x => x.AdicionalId);
                    table.ForeignKey(
                        name: "FK_Adicional_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId");
                });

            migrationBuilder.CreateTable(
                name: "CarritoProductoAdicional",
                columns: table => new
                {
                    CarritoProductoAdicionalId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarritoProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    AdicionalId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarritoProductoAdicional", x => x.CarritoProductoAdicionalId);
                    table.ForeignKey(
                        name: "FK_CarritoProductoAdicional_Adicional_AdicionalId",
                        column: x => x.AdicionalId,
                        principalTable: "Adicional",
                        principalColumn: "AdicionalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarritoProductoAdicional_CarritoProductos_CarritoProductoId",
                        column: x => x.CarritoProductoId,
                        principalTable: "CarritoProductos",
                        principalColumn: "CarritoProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adicional_ProductoId",
                table: "Adicional",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarritoProductoAdicional_AdicionalId",
                table: "CarritoProductoAdicional",
                column: "AdicionalId");

            migrationBuilder.CreateIndex(
                name: "IX_CarritoProductoAdicional_CarritoProductoId",
                table: "CarritoProductoAdicional",
                column: "CarritoProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProductos_Pedidos_PedidoId",
                table: "PedidoProductos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "PedidoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProductos_Pedidos_PedidoId",
                table: "PedidoProductos");

            migrationBuilder.DropTable(
                name: "CarritoProductoAdicional");

            migrationBuilder.DropTable(
                name: "Adicional");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "PedidoProductos",
                newName: "PedidoId1");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoProductos_PedidoId",
                table: "PedidoProductos",
                newName: "IX_PedidoProductos_PedidoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProductos_Pedidos_PedidoId1",
                table: "PedidoProductos",
                column: "PedidoId1",
                principalTable: "Pedidos",
                principalColumn: "PedidoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
