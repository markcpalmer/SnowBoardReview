using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class SeedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Snowboards",
                columns: new[] { "ID", "BrandName", "ModelDescription", "ModelName", "ProductImage" },
                values: new object[] { 1, null, "", "William", "Shakespeare" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
