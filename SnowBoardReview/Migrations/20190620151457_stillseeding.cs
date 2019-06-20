using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class stillseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "CategoryName", "ProductDescription", "ProductImage", "ProductName", "UserReview" },
                values: new object[,]
                {
                    { 2, " latino board", "luis", "ok", "diablo", "hated it" },
                    { 3, " bear board", "matt", "decent still", "polar bear", "Decent yo" }
                });

            migrationBuilder.InsertData(
                table: "Snowboards",
                columns: new[] { "ID", "BrandName", "ModelDescription", "ModelName", "ProductImage" },
                values: new object[,]
                {
                    { 2, null, "blue", "x200", "tree" },
                    { 3, null, "red", "W40", "water" }
                });

            migrationBuilder.InsertData(
                table: "SnowboardReviews",
                columns: new[] { "ID", "ReviewID", "SnowboardID" },
                values: new object[] { 3, 3, 2 });

            migrationBuilder.InsertData(
                table: "SnowboardReviews",
                columns: new[] { "ID", "ReviewID", "SnowboardID" },
                values: new object[] { 2, 2, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SnowboardReviews",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SnowboardReviews",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
