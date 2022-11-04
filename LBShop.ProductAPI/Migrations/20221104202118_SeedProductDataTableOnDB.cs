using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LBShop.ProductAPI.Migrations
{
    public partial class SeedProductDataTableOnDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 1L, "Canecas", "Descrição", "Imagem URL", "Caneca 5", "9,70" },
                    { 11L, "Canecas", "Descrição", "Imagem URL", "Caneca 5", "9,70" },
                    { 21L, "Canecas", "Descrição", "Imagem URL", "Caneca 5", "9,70" },
                    { 31L, "Canecas", "Descrição", "Imagem URL", "Caneca 5", "9,70" },
                    { 41L, "Canecas", "Descrição", "Imagem URL", "Caneca 5", "9,70" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 41L);
        }
    }
}
