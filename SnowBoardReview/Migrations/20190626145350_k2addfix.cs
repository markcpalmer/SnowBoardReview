using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class k2addfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 4,
                column: "ProductImage",
                value: "/images/k2shark.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 4,
                column: "ProductImage",
                value: "images/k2shark.jpg");
        }
    }
}
