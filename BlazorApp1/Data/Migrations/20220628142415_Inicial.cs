using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Precio = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carritos",
                columns: table => new
                {
                    CarritoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carritos", x => x.CarritoId);
                    table.ForeignKey(
                        name: "FK_Carritos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.PedidoId);
                    table.ForeignKey(
                        name: "FK_Pedidos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adicionales",
                columns: table => new
                {
                    AdicionalId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Precio = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adicionales", x => x.AdicionalId);
                    table.ForeignKey(
                        name: "FK_Adicionales_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarritoProductos",
                columns: table => new
                {
                    CarritoProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarritoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarritoProductos", x => x.CarritoProductoId);
                    table.ForeignKey(
                        name: "FK_CarritoProductos_Carritos_CarritoId",
                        column: x => x.CarritoId,
                        principalTable: "Carritos",
                        principalColumn: "CarritoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarritoProductos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PedidoProductos",
                columns: table => new
                {
                    PedidoProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PedidoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoProductos", x => x.PedidoProductoId);
                    table.ForeignKey(
                        name: "FK_PedidoProductos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoProductos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_CarritoProductoAdicional_Adicionales_AdicionalId",
                        column: x => x.AdicionalId,
                        principalTable: "Adicionales",
                        principalColumn: "AdicionalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarritoProductoAdicional_CarritoProductos_CarritoProductoId",
                        column: x => x.CarritoProductoId,
                        principalTable: "CarritoProductos",
                        principalColumn: "CarritoProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Nombre" },
                values: new object[] { 1, "Choripan" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Nombre" },
                values: new object[] { 2, "Pizza" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Nombre" },
                values: new object[] { 3, "Torta" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Nombre" },
                values: new object[] { 4, "Hamburguesa" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Nombre" },
                values: new object[] { 5, "Empanada" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Nombre" },
                values: new object[] { 6, "Bebida" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Nombre", "Password" },
                values: new object[] { 1, "guest", "password" });

            migrationBuilder.InsertData(
                table: "Carritos",
                columns: new[] { "CarritoId", "UsuarioId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 1, 1, "Choripan", 100 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 4, 4, "Hamburguesa", 0 });

            migrationBuilder.InsertData(
                table: "Adicionales",
                columns: new[] { "AdicionalId", "Nombre", "Precio", "ProductoId" },
                values: new object[] { 1, "Salsa criolla", 0, 1 });

            migrationBuilder.InsertData(
                table: "Adicionales",
                columns: new[] { "AdicionalId", "Nombre", "Precio", "ProductoId" },
                values: new object[] { 2, "Chimichurri", 0, 1 });

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

            migrationBuilder.CreateIndex(
                name: "IX_Adicionales_ProductoId",
                table: "Adicionales",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarritoProductoAdicional_AdicionalId",
                table: "CarritoProductoAdicional",
                column: "AdicionalId");

            migrationBuilder.CreateIndex(
                name: "IX_CarritoProductoAdicional_CarritoProductoId",
                table: "CarritoProductoAdicional",
                column: "CarritoProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarritoProductos_CarritoId",
                table: "CarritoProductos",
                column: "CarritoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarritoProductos_ProductoId",
                table: "CarritoProductos",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carritos_UsuarioId",
                table: "Carritos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProductos_PedidoId",
                table: "PedidoProductos",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProductos_ProductoId",
                table: "PedidoProductos",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_UsuarioId",
                table: "Pedidos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaId",
                table: "Productos",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarritoProductoAdicional");

            migrationBuilder.DropTable(
                name: "PedidoProductos");

            migrationBuilder.DropTable(
                name: "Adicionales");

            migrationBuilder.DropTable(
                name: "CarritoProductos");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Carritos");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
