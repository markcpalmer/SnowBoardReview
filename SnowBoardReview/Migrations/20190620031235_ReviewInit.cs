using Microsoft.EntityFrameworkCore.Migrations;
namespace SnowBoardReview.Migrations
{
    public partial class ReviewInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SnowboardBrand_Snowboards_SnowboardID",
                table: "SnowboardBrand");

            migrationBuilder.DropForeignKey(
                name: "FK_SnowboardReview_Reviews_ReviewID",
                table: "SnowboardReview");

            migrationBuilder.DropForeignKey(
                name: "FK_SnowboardReview_Snowboards_SnowboardID",
                table: "SnowboardReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SnowboardReview",
                table: "SnowboardReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SnowboardBrand",
                table: "SnowboardBrand");

            migrationBuilder.RenameTable(
                name: "SnowboardReview",
                newName: "SnowboardReviews");

            migrationBuilder.RenameTable(
                name: "SnowboardBrand",
                newName: "SnowboardBrands");

            migrationBuilder.RenameIndex(
                name: "IX_SnowboardReview_SnowboardID",
                table: "SnowboardReviews",
                newName: "IX_SnowboardReviews_SnowboardID");

            migrationBuilder.RenameIndex(
                name: "IX_SnowboardReview_ReviewID",
                table: "SnowboardReviews",
                newName: "IX_SnowboardReviews_ReviewID");

            migrationBuilder.RenameIndex(
                name: "IX_SnowboardBrand_SnowboardID",
                table: "SnowboardBrands",
                newName: "IX_SnowboardBrands_SnowboardID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SnowboardReviews",
                table: "SnowboardReviews",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SnowboardBrands",
                table: "SnowboardBrands",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SnowboardBrands_Snowboards_SnowboardID",
                table: "SnowboardBrands",
                column: "SnowboardID",
                principalTable: "Snowboards",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SnowboardReviews_Reviews_ReviewID",
                table: "SnowboardReviews",
                column: "ReviewID",
                principalTable: "Reviews",
                principalColumn: "ReviewID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SnowboardReviews_Snowboards_SnowboardID",
                table: "SnowboardReviews",
                column: "SnowboardID",
                principalTable: "Snowboards",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SnowboardBrands_Snowboards_SnowboardID",
                table: "SnowboardBrands");

            migrationBuilder.DropForeignKey(
                name: "FK_SnowboardReviews_Reviews_ReviewID",
                table: "SnowboardReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_SnowboardReviews_Snowboards_SnowboardID",
                table: "SnowboardReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SnowboardReviews",
                table: "SnowboardReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SnowboardBrands",
                table: "SnowboardBrands");

            migrationBuilder.RenameTable(
                name: "SnowboardReviews",
                newName: "SnowboardReview");

            migrationBuilder.RenameTable(
                name: "SnowboardBrands",
                newName: "SnowboardBrand");

            migrationBuilder.RenameIndex(
                name: "IX_SnowboardReviews_SnowboardID",
                table: "SnowboardReview",
                newName: "IX_SnowboardReview_SnowboardID");

            migrationBuilder.RenameIndex(
                name: "IX_SnowboardReviews_ReviewID",
                table: "SnowboardReview",
                newName: "IX_SnowboardReview_ReviewID");

            migrationBuilder.RenameIndex(
                name: "IX_SnowboardBrands_SnowboardID",
                table: "SnowboardBrand",
                newName: "IX_SnowboardBrand_SnowboardID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SnowboardReview",
                table: "SnowboardReview",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SnowboardBrand",
                table: "SnowboardBrand",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SnowboardBrand_Snowboards_SnowboardID",
                table: "SnowboardBrand",
                column: "SnowboardID",
                principalTable: "Snowboards",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SnowboardReview_Reviews_ReviewID",
                table: "SnowboardReview",
                column: "ReviewID",
                principalTable: "Reviews",
                principalColumn: "ReviewID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SnowboardReview_Snowboards_SnowboardID",
                table: "SnowboardReview",
                column: "SnowboardID",
                principalTable: "Snowboards",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
