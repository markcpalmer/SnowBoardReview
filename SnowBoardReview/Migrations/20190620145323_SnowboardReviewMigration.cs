using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class SnowboardReviewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SnowboardReviews",
                columns: new[] { "ID", "ReviewID", "SnowboardID" },
                values: new object[] { 1, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SnowboardReviews",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
