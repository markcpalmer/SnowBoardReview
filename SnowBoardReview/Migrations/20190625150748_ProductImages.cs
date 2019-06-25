using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class ProductImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ModelName", "ProductImage" },
                values: new object[] { "Kaleidoscope", "/images/BurtonKaleidoscope.jpg" });

            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 2,
                column: "ProductImage",
                value: "/images/MarkBrandX200.png");

            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 3,
                column: "ProductImage",
                value: "/images/MarkBrandW40.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ModelName", "ProductImage" },
                values: new object[] { "William", "Shakespeare" });

            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 2,
                column: "ProductImage",
                value: "tree");

            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 3,
                column: "ProductImage",
                value: "water");
        }
    }
}
