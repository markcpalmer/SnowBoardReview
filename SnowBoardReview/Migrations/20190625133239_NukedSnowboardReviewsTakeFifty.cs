using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class NukedSnowboardReviewsTakeFifty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    CategoryName = table.Column<string>(nullable: true),
                    ReviewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserReview = table.Column<string>(nullable: true)
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
                    Brand = table.Column<string>(nullable: true),
                    BrandImage = table.Column<string>(nullable: true)
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
                    ProductImage = table.Column<string>(nullable: true),
                    SnowboardBrandID = table.Column<int>(nullable: false),
                    ReviewID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snowboards", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Snowboards_Reviews_ReviewID",
                        column: x => x.ReviewID,
                        principalTable: "Reviews",
                        principalColumn: "ReviewID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Snowboards_SnowboardBrands_SnowboardBrandID",
                        column: x => x.SnowboardBrandID,
                        principalTable: "SnowboardBrands",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "CategoryName", "UserReview" },
                values: new object[,]
                {
                    { 1, " cool board", "This is cool" },
                    { 2, " latino board", "hated it" },
                    { 3, " bear board", "Decent yo" }
                });

            migrationBuilder.InsertData(
                table: "SnowboardBrands",
                columns: new[] { "ID", "Brand", "BrandImage" },
                values: new object[,]
                {
                    { 1, "Burton", "/images/burton.jpeg" },
                    { 2, "Mark's Brand", "/images/Marksboard.png" },
                    { 3, "K2", "/images/K2Logo.png" }
                });

            migrationBuilder.InsertData(
                table: "Snowboards",
                columns: new[] { "ID", "ModelDescription", "ModelName", "ProductImage", "ReviewID", "SnowboardBrandID" },
                values: new object[] { 1, "", "William", "Shakespeare", 2, 1 });

            migrationBuilder.InsertData(
                table: "Snowboards",
                columns: new[] { "ID", "ModelDescription", "ModelName", "ProductImage", "ReviewID", "SnowboardBrandID" },
                values: new object[] { 2, "blue", "x200", "tree", 1, 2 });

            migrationBuilder.InsertData(
                table: "Snowboards",
                columns: new[] { "ID", "ModelDescription", "ModelName", "ProductImage", "ReviewID", "SnowboardBrandID" },
                values: new object[] { 3, "red", "W40", "water", 3, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Snowboards_ReviewID",
                table: "Snowboards",
                column: "ReviewID");

            migrationBuilder.CreateIndex(
                name: "IX_Snowboards_SnowboardBrandID",
                table: "Snowboards",
                column: "SnowboardBrandID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Snowboards");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "SnowboardBrands");
        }
    }
}
