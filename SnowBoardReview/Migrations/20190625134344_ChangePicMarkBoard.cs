using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class ChangePicMarkBoard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SnowboardBrands",
                keyColumn: "ID",
                keyValue: 2,
                column: "BrandImage",
                value: "/images/BPowerLogo.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SnowboardBrands",
                keyColumn: "ID",
                keyValue: 2,
                column: "BrandImage",
                value: "/images/Marksboard.png");
        }
    }
}
