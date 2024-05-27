using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal.Migrations
{
    public partial class Migracion4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "proveedorid",
                table: "Producto",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "stock",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Producto_proveedorid",
                table: "Producto",
                column: "proveedorid");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Proveedor_proveedorid",
                table: "Producto",
                column: "proveedorid",
                principalTable: "Proveedor",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Proveedor_proveedorid",
                table: "Producto");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropIndex(
                name: "IX_Producto_proveedorid",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "proveedorid",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "stock",
                table: "Producto");
        }
    }
}
