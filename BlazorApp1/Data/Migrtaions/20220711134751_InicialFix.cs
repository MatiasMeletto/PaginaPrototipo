using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Data.Migrtaions
{
    public partial class InicialFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pedidoProductoAdicionales",
                columns: table => new
                {
                    PedidoProductoAdicionalId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PedidoProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    AdicionalId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidoProductoAdicionales", x => x.PedidoProductoAdicionalId);
                    table.ForeignKey(
                        name: "FK_pedidoProductoAdicionales_Adicionales_AdicionalId",
                        column: x => x.AdicionalId,
                        principalTable: "Adicionales",
                        principalColumn: "AdicionalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pedidoProductoAdicionales_PedidoProductos_PedidoProductoId",
                        column: x => x.PedidoProductoId,
                        principalTable: "PedidoProductos",
                        principalColumn: "PedidoProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pedidoProductoAdicionales_AdicionalId",
                table: "pedidoProductoAdicionales",
                column: "AdicionalId");

            migrationBuilder.CreateIndex(
                name: "IX_pedidoProductoAdicionales_PedidoProductoId",
                table: "pedidoProductoAdicionales",
                column: "PedidoProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pedidoProductoAdicionales");
        }
    }
}
