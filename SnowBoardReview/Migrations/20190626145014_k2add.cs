using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class k2add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Snowboards",
                columns: new[] { "ID", "ModelDescription", "ModelName", "ProductImage", "SnowboardBrandID" },
                values: new object[] { 4, "It has a shark painted on it! what more is there to say?", "Shark", "images/k2shark.jpg", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
