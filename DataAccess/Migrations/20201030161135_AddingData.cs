using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "ASP", "Aseo Personal" },
                    { "HGR", "Hogar" },
                    { "PRF", "Perfumería" },
                    { "SLD", "Salud" },
                    { "VDJ", "Video Juegos" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseID", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "4c3ad421-5539-4315-937d-a103d80bd769", "Dirección 1", "Bodega Central" },
                    { "e38cb871-f2a5-4835-bf39-d8acd81aa0e7", "Dirección 25", "Bodega Occidental" },
                    { "fcb9ef13-a786-471e-bcb3-23f9bbbfdad6", "Dirección Desconocida", "Bodega Clandestina" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "ASP");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "HGR");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "PRF");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "SLD");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "VDJ");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseID",
                keyValue: "4c3ad421-5539-4315-937d-a103d80bd769");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseID",
                keyValue: "e38cb871-f2a5-4835-bf39-d8acd81aa0e7");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseID",
                keyValue: "fcb9ef13-a786-471e-bcb3-23f9bbbfdad6");
        }
    }
}
