using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class PotentialBrandFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ProductDescription = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    CategoryName = table.Column<string>(nullable: true),
                    ReviewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserReview = table.Column<string>(nullable: true),
                    ProductImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewID);
                });

            migrationBuilder.CreateTable(
                name: "SnowboardBrands",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Brand = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnowboardBrands", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Snowboards",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ModelDescription = table.Column<string>(nullable: true),
                    ModelName = table.Column<string>(nullable: true),
                    BrandName = table.Column<string>(nullable: true),
                    ProductImage = table.Column<string>(nullable: true),
                    SnowboardBrandID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snowboards", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Snowboards_SnowboardBrands_SnowboardBrandID",
                        column: x => x.SnowboardBrandID,
                        principalTable: "SnowboardBrands",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SnowboardReviews",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SnowboardID = table.Column<int>(nullable: false),
                    ReviewID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnowboardReviews", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SnowboardReviews_Reviews_ReviewID",
                        column: x => x.ReviewID,
                        principalTable: "Reviews",
                        principalColumn: "ReviewID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SnowboardReviews_Snowboards_SnowboardID",
                        column: x => x.SnowboardID,
                        principalTable: "Snowboards",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "CategoryName", "ProductDescription", "ProductImage", "ProductName", "UserReview" },
                values: new object[,]
                {
                    { 1, " cool board", "mark", "Pretty", "take 2", "This is cool" },
                    { 2, " latino board", "luis", "ok", "diablo", "hated it" },
                    { 3, " bear board", "matt", "decent still", "polar bear", "Decent yo" }
                });

            migrationBuilder.InsertData(
                table: "SnowboardBrands",
                columns: new[] { "ID", "Brand" },
                values: new object[,]
                {
                    { 1, "Burton" },
                    { 2, "Mark's Brand" },
                    { 3, "K2" }
                });

            migrationBuilder.InsertData(
                table: "Snowboards",
                columns: new[] { "ID", "BrandName", "ModelDescription", "ModelName", "ProductImage", "SnowboardBrandID" },
                values: new object[] { 1, null, "", "William", "Shakespeare", 1 });

            migrationBuilder.InsertData(
                table: "Snowboards",
                columns: new[] { "ID", "BrandName", "ModelDescription", "ModelName", "ProductImage", "SnowboardBrandID" },
                values: new object[] { 2, null, "blue", "x200", "tree", 2 });

            migrationBuilder.InsertData(
                table: "Snowboards",
                columns: new[] { "ID", "BrandName", "ModelDescription", "ModelName", "ProductImage", "SnowboardBrandID" },
                values: new object[] { 3, null, "red", "W40", "water", 2 });

            migrationBuilder.InsertData(
                table: "SnowboardReviews",
                columns: new[] { "ID", "ReviewID", "SnowboardID" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "SnowboardReviews",
                columns: new[] { "ID", "ReviewID", "SnowboardID" },
                values: new object[] { 3, 3, 2 });

            migrationBuilder.InsertData(
                table: "SnowboardReviews",
                columns: new[] { "ID", "ReviewID", "SnowboardID" },
                values: new object[] { 2, 2, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_SnowboardReviews_ReviewID",
                table: "SnowboardReviews",
                column: "ReviewID");

            migrationBuilder.CreateIndex(
                name: "IX_SnowboardReviews_SnowboardID",
                table: "SnowboardReviews",
                column: "SnowboardID");

            migrationBuilder.CreateIndex(
                name: "IX_Snowboards_SnowboardBrandID",
                table: "Snowboards",
                column: "SnowboardBrandID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SnowboardReviews");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Snowboards");

            migrationBuilder.DropTable(
                name: "SnowboardBrands");
        }
    }
}
