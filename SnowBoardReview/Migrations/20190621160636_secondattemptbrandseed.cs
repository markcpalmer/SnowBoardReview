using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class secondattemptbrandseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SnowboardBrands",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SnowboardBrands",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "SnowboardBrands",
                keyColumn: "ID",
                keyValue: 3,
                column: "SnowboardID",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SnowboardBrands",
                keyColumn: "ID",
                keyValue: 1,
                column: "SnowboardID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SnowboardBrands",
                keyColumn: "ID",
                keyValue: 2,
                column: "SnowboardID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SnowboardBrands",
                keyColumn: "ID",
                keyValue: 3,
                column: "SnowboardID",
                value: 0);
        }
    }
}
