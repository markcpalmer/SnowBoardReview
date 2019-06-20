using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class ReveiewSeedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "CategoryName", "ProductDescription", "ProductImage", "ProductName", "UserReview" },
                values: new object[] { 1, " cool board", "mark", "Pretty", "take 2", "This is cool" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 1);
        }
    }
}
