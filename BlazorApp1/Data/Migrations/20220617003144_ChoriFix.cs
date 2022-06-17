using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Data.Migrations
{
    public partial class ChoriFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bebidas_Carrito_CarritoId",
                table: "Bebidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Choripanes_Carrito_CarritoId",
                table: "Choripanes");

            migrationBuilder.DropForeignKey(
                name: "FK_Empanadas_Carrito_CarritoId",
                table: "Empanadas");

            migrationBuilder.DropForeignKey(
                name: "FK_hamburguesaCantidades_Carrito_CarritoId",
                table: "hamburguesaCantidades");

            migrationBuilder.DropForeignKey(
                name: "FK_HamburguesaPrecios_Carrito_CarritoId",
                table: "HamburguesaPrecios");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Carrito_CarritoId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tortas_Carrito_CarritoId",
                table: "Tortas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carrito",
                table: "Carrito");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Choripanes");

            migrationBuilder.RenameTable(
                name: "Carrito",
                newName: "Carritos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carritos",
                table: "Carritos",
                column: "CarritoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bebidas_Carritos_CarritoId",
                table: "Bebidas",
                column: "CarritoId",
                principalTable: "Carritos",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Choripanes_Carritos_CarritoId",
                table: "Choripanes",
                column: "CarritoId",
                principalTable: "Carritos",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empanadas_Carritos_CarritoId",
                table: "Empanadas",
                column: "CarritoId",
                principalTable: "Carritos",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_hamburguesaCantidades_Carritos_CarritoId",
                table: "hamburguesaCantidades",
                column: "CarritoId",
                principalTable: "Carritos",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HamburguesaPrecios_Carritos_CarritoId",
                table: "HamburguesaPrecios",
                column: "CarritoId",
                principalTable: "Carritos",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Carritos_CarritoId",
                table: "Pizzas",
                column: "CarritoId",
                principalTable: "Carritos",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tortas_Carritos_CarritoId",
                table: "Tortas",
                column: "CarritoId",
                principalTable: "Carritos",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bebidas_Carritos_CarritoId",
                table: "Bebidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Choripanes_Carritos_CarritoId",
                table: "Choripanes");

            migrationBuilder.DropForeignKey(
                name: "FK_Empanadas_Carritos_CarritoId",
                table: "Empanadas");

            migrationBuilder.DropForeignKey(
                name: "FK_hamburguesaCantidades_Carritos_CarritoId",
                table: "hamburguesaCantidades");

            migrationBuilder.DropForeignKey(
                name: "FK_HamburguesaPrecios_Carritos_CarritoId",
                table: "HamburguesaPrecios");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Carritos_CarritoId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tortas_Carritos_CarritoId",
                table: "Tortas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carritos",
                table: "Carritos");

            migrationBuilder.RenameTable(
                name: "Carritos",
                newName: "Carrito");

            migrationBuilder.AddColumn<int>(
                name: "Precio",
                table: "Choripanes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carrito",
                table: "Carrito",
                column: "CarritoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bebidas_Carrito_CarritoId",
                table: "Bebidas",
                column: "CarritoId",
                principalTable: "Carrito",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Choripanes_Carrito_CarritoId",
                table: "Choripanes",
                column: "CarritoId",
                principalTable: "Carrito",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empanadas_Carrito_CarritoId",
                table: "Empanadas",
                column: "CarritoId",
                principalTable: "Carrito",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_hamburguesaCantidades_Carrito_CarritoId",
                table: "hamburguesaCantidades",
                column: "CarritoId",
                principalTable: "Carrito",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HamburguesaPrecios_Carrito_CarritoId",
                table: "HamburguesaPrecios",
                column: "CarritoId",
                principalTable: "Carrito",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Carrito_CarritoId",
                table: "Pizzas",
                column: "CarritoId",
                principalTable: "Carrito",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tortas_Carrito_CarritoId",
                table: "Tortas",
                column: "CarritoId",
                principalTable: "Carrito",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
