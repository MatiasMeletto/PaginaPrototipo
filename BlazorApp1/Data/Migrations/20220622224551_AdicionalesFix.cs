using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Data.Migrations
{
    public partial class AdicionalesFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adicional_Productos_ProductoId",
                table: "Adicional");

            migrationBuilder.DropForeignKey(
                name: "FK_CarritoProductoAdicional_Adicional_AdicionalId",
                table: "CarritoProductoAdicional");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adicional",
                table: "Adicional");

            migrationBuilder.RenameTable(
                name: "Adicional",
                newName: "Adicionales");

            migrationBuilder.RenameIndex(
                name: "IX_Adicional_ProductoId",
                table: "Adicionales",
                newName: "IX_Adicionales_ProductoId");

            migrationBuilder.AlterColumn<int>(
                name: "ProductoId",
                table: "Adicionales",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adicionales",
                table: "Adicionales",
                column: "AdicionalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adicionales_Productos_ProductoId",
                table: "Adicionales",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarritoProductoAdicional_Adicionales_AdicionalId",
                table: "CarritoProductoAdicional",
                column: "AdicionalId",
                principalTable: "Adicionales",
                principalColumn: "AdicionalId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adicionales_Productos_ProductoId",
                table: "Adicionales");

            migrationBuilder.DropForeignKey(
                name: "FK_CarritoProductoAdicional_Adicionales_AdicionalId",
                table: "CarritoProductoAdicional");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adicionales",
                table: "Adicionales");

            migrationBuilder.RenameTable(
                name: "Adicionales",
                newName: "Adicional");

            migrationBuilder.RenameIndex(
                name: "IX_Adicionales_ProductoId",
                table: "Adicional",
                newName: "IX_Adicional_ProductoId");

            migrationBuilder.AlterColumn<int>(
                name: "ProductoId",
                table: "Adicional",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adicional",
                table: "Adicional",
                column: "AdicionalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adicional_Productos_ProductoId",
                table: "Adicional",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarritoProductoAdicional_Adicional_AdicionalId",
                table: "CarritoProductoAdicional",
                column: "AdicionalId",
                principalTable: "Adicional",
                principalColumn: "AdicionalId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
