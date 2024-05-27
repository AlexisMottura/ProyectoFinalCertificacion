using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal.Migrations
{
    public partial class Migracion5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "Producto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    nroVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    clienteid = table.Column<int>(type: "int", nullable: true),
                    productoid = table.Column<int>(type: "int", nullable: true),
                    cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta", x => x.nroVenta);
                    table.ForeignKey(
                        name: "FK_Venta_Cliente_clienteid",
                        column: x => x.clienteid,
                        principalTable: "Cliente",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Venta_Producto_productoid",
                        column: x => x.productoid,
                        principalTable: "Producto",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Venta_clienteid",
                table: "Venta",
                column: "clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_productoid",
                table: "Venta",
                column: "productoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "Producto");
        }
    }
}
