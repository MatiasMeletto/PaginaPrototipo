﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Apellido = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carritos",
                columns: table => new
                {
                    CarritoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carritos", x => x.CarritoId);
                    table.ForeignKey(
                        name: "FK_Carritos_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.PedidoId);
                    table.ForeignKey(
                        name: "FK_Pedidos_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 1, 1, "Choripan", 100 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 3, 3, "Torta de chocolate", 500 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 4, 4, "Hamburguesa", 0 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 5, 3, "Torta de zanahoria", 600 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 6, 3, "Torta de vainilla", 500 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 7, 3, "Pastafrola", 700 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 8, 3, "Brownie c/mani", 750 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 9, 3, "Brownie c/mani", 800 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 10, 3, "Torta de Frambuesa", 800 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 11, 2, "Muzzarela", 700 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 12, 2, "Especial", 900 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 13, 2, "Jamon", 850 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 14, 2, "Napolitana", 900 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 15, 2, "4 Quesos", 950 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 16, 2, "Cebolla", 850 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 17, 2, "Anchoa", 900 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 18, 2, "Anana", 850 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 19, 2, "Huevo", 850 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 20, 2, "Choclo", 850 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 21, 2, "Milan", 850 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 22, 5, "Carne", 100 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 23, 5, "Choclo", 100 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 24, 5, "Verdura", 100 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 25, 5, "Pollo", 100 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 27, 5, "JamonYQueso", 100 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 28, 6, "Coca-Cola", 170 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 29, 6, "Pepsi", 150 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 30, 6, "Sprite", 170 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Nombre", "Precio" },
                values: new object[] { 31, 6, "Fanta", 150 });

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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

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
                name: "IX_pedidoProductoAdicionales_AdicionalId",
                table: "pedidoProductoAdicionales",
                column: "AdicionalId");

            migrationBuilder.CreateIndex(
                name: "IX_pedidoProductoAdicionales_PedidoProductoId",
                table: "pedidoProductoAdicionales",
                column: "PedidoProductoId");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CarritoProductoAdicional");

            migrationBuilder.DropTable(
                name: "pedidoProductoAdicionales");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CarritoProductos");

            migrationBuilder.DropTable(
                name: "Adicionales");

            migrationBuilder.DropTable(
                name: "PedidoProductos");

            migrationBuilder.DropTable(
                name: "Carritos");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}