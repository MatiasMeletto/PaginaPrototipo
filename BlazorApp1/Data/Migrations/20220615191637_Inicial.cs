using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carrito",
                columns: table => new
                {
                    CarritoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrito", x => x.CarritoId);
                });

            migrationBuilder.CreateTable(
                name: "Bebidas",
                columns: table => new
                {
                    BebidaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Variedad = table.Column<string>(type: "TEXT", nullable: false),
                    Lechuga = table.Column<int>(type: "INTEGER", nullable: false),
                    Tomate = table.Column<int>(type: "INTEGER", nullable: false),
                    CarritoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bebidas", x => x.BebidaId);
                    table.ForeignKey(
                        name: "FK_Bebidas_Carrito_CarritoId",
                        column: x => x.CarritoId,
                        principalTable: "Carrito",
                        principalColumn: "CarritoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Choripanes",
                columns: table => new
                {
                    ChoripanId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Criolla = table.Column<int>(type: "INTEGER", nullable: false),
                    Chimichurri = table.Column<int>(type: "INTEGER", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<int>(type: "INTEGER", nullable: false),
                    CarritoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Choripanes", x => x.ChoripanId);
                    table.ForeignKey(
                        name: "FK_Choripanes_Carrito_CarritoId",
                        column: x => x.CarritoId,
                        principalTable: "Carrito",
                        principalColumn: "CarritoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empanadas",
                columns: table => new
                {
                    EmpanadaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Variedad = table.Column<string>(type: "TEXT", nullable: false),
                    Lechuga = table.Column<int>(type: "INTEGER", nullable: false),
                    Tomate = table.Column<int>(type: "INTEGER", nullable: false),
                    CarritoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empanadas", x => x.EmpanadaId);
                    table.ForeignKey(
                        name: "FK_Empanadas_Carrito_CarritoId",
                        column: x => x.CarritoId,
                        principalTable: "Carrito",
                        principalColumn: "CarritoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hamburguesaCantidades",
                columns: table => new
                {
                    HamburguesaCantId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Pan = table.Column<int>(type: "INTEGER", nullable: false),
                    Carne = table.Column<int>(type: "INTEGER", nullable: false),
                    Lechuga = table.Column<int>(type: "INTEGER", nullable: false),
                    Tomate = table.Column<int>(type: "INTEGER", nullable: false),
                    Huevo = table.Column<int>(type: "INTEGER", nullable: false),
                    Bacon = table.Column<int>(type: "INTEGER", nullable: false),
                    Cheddar = table.Column<int>(type: "INTEGER", nullable: false),
                    Tybo = table.Column<int>(type: "INTEGER", nullable: false),
                    Jamon = table.Column<int>(type: "INTEGER", nullable: false),
                    Cebolla = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayonesa = table.Column<int>(type: "INTEGER", nullable: false),
                    Ketchup = table.Column<int>(type: "INTEGER", nullable: false),
                    Mostaza = table.Column<int>(type: "INTEGER", nullable: false),
                    Sabora = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<int>(type: "INTEGER", nullable: false),
                    CarritoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hamburguesaCantidades", x => x.HamburguesaCantId);
                    table.ForeignKey(
                        name: "FK_hamburguesaCantidades_Carrito_CarritoId",
                        column: x => x.CarritoId,
                        principalTable: "Carrito",
                        principalColumn: "CarritoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HamburguesaPrecios",
                columns: table => new
                {
                    HamburguesaPrecioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Pan = table.Column<int>(type: "INTEGER", nullable: false),
                    Carne = table.Column<int>(type: "INTEGER", nullable: false),
                    Lechuga = table.Column<int>(type: "INTEGER", nullable: false),
                    Tomate = table.Column<int>(type: "INTEGER", nullable: false),
                    Huevo = table.Column<int>(type: "INTEGER", nullable: false),
                    Bacon = table.Column<int>(type: "INTEGER", nullable: false),
                    Cheddar = table.Column<int>(type: "INTEGER", nullable: false),
                    Tybo = table.Column<int>(type: "INTEGER", nullable: false),
                    Jamon = table.Column<int>(type: "INTEGER", nullable: false),
                    Cebolla = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayonesa = table.Column<int>(type: "INTEGER", nullable: false),
                    Ketchup = table.Column<int>(type: "INTEGER", nullable: false),
                    Mostaza = table.Column<int>(type: "INTEGER", nullable: false),
                    Sabora = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<int>(type: "INTEGER", nullable: false),
                    CarritoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HamburguesaPrecios", x => x.HamburguesaPrecioId);
                    table.ForeignKey(
                        name: "FK_HamburguesaPrecios_Carrito_CarritoId",
                        column: x => x.CarritoId,
                        principalTable: "Carrito",
                        principalColumn: "CarritoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    PizzaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Variedad = table.Column<string>(type: "TEXT", nullable: false),
                    Lechuga = table.Column<int>(type: "INTEGER", nullable: false),
                    Tomate = table.Column<int>(type: "INTEGER", nullable: false),
                    CarritoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.PizzaId);
                    table.ForeignKey(
                        name: "FK_Pizzas_Carrito_CarritoId",
                        column: x => x.CarritoId,
                        principalTable: "Carrito",
                        principalColumn: "CarritoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tortas",
                columns: table => new
                {
                    TortaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    _variedad = table.Column<string>(type: "TEXT", nullable: false),
                    Variedad = table.Column<string>(type: "TEXT", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<int>(type: "INTEGER", nullable: false),
                    CarritoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tortas", x => x.TortaId);
                    table.ForeignKey(
                        name: "FK_Tortas_Carrito_CarritoId",
                        column: x => x.CarritoId,
                        principalTable: "Carrito",
                        principalColumn: "CarritoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bebidas_CarritoId",
                table: "Bebidas",
                column: "CarritoId");

            migrationBuilder.CreateIndex(
                name: "IX_Choripanes_CarritoId",
                table: "Choripanes",
                column: "CarritoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empanadas_CarritoId",
                table: "Empanadas",
                column: "CarritoId");

            migrationBuilder.CreateIndex(
                name: "IX_hamburguesaCantidades_CarritoId",
                table: "hamburguesaCantidades",
                column: "CarritoId");

            migrationBuilder.CreateIndex(
                name: "IX_HamburguesaPrecios_CarritoId",
                table: "HamburguesaPrecios",
                column: "CarritoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CarritoId",
                table: "Pizzas",
                column: "CarritoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tortas_CarritoId",
                table: "Tortas",
                column: "CarritoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bebidas");

            migrationBuilder.DropTable(
                name: "Choripanes");

            migrationBuilder.DropTable(
                name: "Empanadas");

            migrationBuilder.DropTable(
                name: "hamburguesaCantidades");

            migrationBuilder.DropTable(
                name: "HamburguesaPrecios");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Tortas");

            migrationBuilder.DropTable(
                name: "Carrito");
        }
    }
}
