using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class AddedDescriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 1,
                column: "ModelDescription",
                value: "All Mountain, Freestyle- Light, short and flexible");

            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 2,
                column: "ModelDescription",
                value: "Freeride, Freestyle- Ideal for backcountry riding.");

            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 3,
                column: "ModelDescription",
                value: "Splitboard- Split in half for backcountry climbing.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 1,
                column: "ModelDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 2,
                column: "ModelDescription",
                value: "blue");

            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 3,
                column: "ModelDescription",
                value: "red");
        }
    }
}
