using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class boardid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Snowboards_SnowboardID",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "SnowboardID",
                table: "Reviews",
                newName: "BoardID");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_SnowboardID",
                table: "Reviews",
                newName: "IX_Reviews_BoardID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Snowboards_BoardID",
                table: "Reviews",
                column: "BoardID",
                principalTable: "Snowboards",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Snowboards_BoardID",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "BoardID",
                table: "Reviews",
                newName: "SnowboardID");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_BoardID",
                table: "Reviews",
                newName: "IX_Reviews_SnowboardID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Snowboards_SnowboardID",
                table: "Reviews",
                column: "SnowboardID",
                principalTable: "Snowboards",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
