using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class UpdatedViewPaths : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Snowboards_Reviews_ReviewID",
                table: "Snowboards");

            migrationBuilder.DropIndex(
                name: "IX_Snowboards_ReviewID",
                table: "Snowboards");

            migrationBuilder.DropColumn(
                name: "ReviewID",
                table: "Snowboards");

            migrationBuilder.AddColumn<int>(
                name: "SnowboardID",
                table: "Reviews",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 1,
                column: "SnowboardID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 2,
                column: "SnowboardID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 3,
                column: "SnowboardID",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_SnowboardID",
                table: "Reviews",
                column: "SnowboardID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Snowboards_SnowboardID",
                table: "Reviews",
                column: "SnowboardID",
                principalTable: "Snowboards",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Snowboards_SnowboardID",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_SnowboardID",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "SnowboardID",
                table: "Reviews");

            migrationBuilder.AddColumn<int>(
                name: "ReviewID",
                table: "Snowboards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 1,
                column: "ReviewID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 2,
                column: "ReviewID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 3,
                column: "ReviewID",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Snowboards_ReviewID",
                table: "Snowboards",
                column: "ReviewID");

            migrationBuilder.AddForeignKey(
                name: "FK_Snowboards_Reviews_ReviewID",
                table: "Snowboards",
                column: "ReviewID",
                principalTable: "Reviews",
                principalColumn: "ReviewID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
