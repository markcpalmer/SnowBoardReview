using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class fixboardsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "ProductImage", "SnowboardBrandID" },
                values: new object[] { "/images/K2board.jpg", 3 });

            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 6,
                column: "SnowboardBrandID",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "ProductImage", "SnowboardBrandID" },
                values: new object[] { "/images/k2board.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 6,
                column: "SnowboardBrandID",
                value: 3);
        }
    }
}
