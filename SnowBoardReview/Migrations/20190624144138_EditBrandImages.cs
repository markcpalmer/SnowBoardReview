using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class EditBrandImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductDescription",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ProductImage",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Reviews");

            migrationBuilder.AddColumn<string>(
                name: "BrandImage",
                table: "SnowboardBrands",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SnowboardBrands",
                keyColumn: "ID",
                keyValue: 1,
                column: "BrandImage",
                value: "/images/burton.jpeg");

            migrationBuilder.UpdateData(
                table: "SnowboardBrands",
                keyColumn: "ID",
                keyValue: 2,
                column: "BrandImage",
                value: "/images/Marksboard.png");

            migrationBuilder.UpdateData(
                table: "SnowboardBrands",
                keyColumn: "ID",
                keyValue: 3,
                column: "BrandImage",
                value: "/images/K2Logo.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrandImage",
                table: "SnowboardBrands");

            migrationBuilder.AddColumn<string>(
                name: "ProductDescription",
                table: "Reviews",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductImage",
                table: "Reviews",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Reviews",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 1,
                columns: new[] { "ProductDescription", "ProductImage", "ProductName" },
                values: new object[] { "mark", "Pretty", "take 2" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 2,
                columns: new[] { "ProductDescription", "ProductImage", "ProductName" },
                values: new object[] { "luis", "ok", "diablo" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 3,
                columns: new[] { "ProductDescription", "ProductImage", "ProductName" },
                values: new object[] { "matt", "decent still", "polar bear" });
        }
    }
}
