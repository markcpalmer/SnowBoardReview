using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class newboards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Snowboards",
                columns: new[] { "ID", "ModelDescription", "ModelName", "ProductImage", "SnowboardBrandID" },
                values: new object[] { 5, "The board that put us on the map!! For shredding and back country climbing", "K2 Standard", "/images/k2board.jpg", 1 });

            migrationBuilder.InsertData(
                table: "Snowboards",
                columns: new[] { "ID", "ModelDescription", "ModelName", "ProductImage", "SnowboardBrandID" },
                values: new object[] { 6, "Customized to your liking!! Shred or backcountry...your choose!!", "Burton Custom", "/images/BurtonCustom.jpg", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}
