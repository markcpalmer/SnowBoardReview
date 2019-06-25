using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class K2BrandPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Reviews",
                columns: table => new
                {
                    CategoryName = table.Column<string>(nullable: true),
                    ReviewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserReview = table.Column<string>(nullable: true),
                    SnowboardID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_Reviews_Snowboards_SnowboardID",
                        column: x => x.SnowboardID,
                        principalTable: "Snowboards",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SnowboardBrands",
                columns: new[] { "ID", "Brand", "BrandImage" },
                values: new object[] { 1, "Burton", "/images/burton.jpeg" });

            migrationBuilder.InsertData(
                table: "SnowboardBrands",
                columns: new[] { "ID", "Brand", "BrandImage" },
                values: new object[] { 2, "Mark's Brand", "/images/BPowerLogo.png" });

            migrationBuilder.InsertData(
                table: "SnowboardBrands",
                columns: new[] { "ID", "Brand", "BrandImage" },
                values: new object[] { 3, "K2", "/images/K2_1.png" });

            migrationBuilder.InsertData(
                table: "Snowboards",
                columns: new[] { "ID", "ModelDescription", "ModelName", "ProductImage", "SnowboardBrandID" },
                values: new object[] { 1, "All Mountain, Freestyle- Light, short and flexible", "Kaleidoscope", "/images/BurtonKaleidoscope.jpg", 1 });

            migrationBuilder.InsertData(
                table: "Snowboards",
                columns: new[] { "ID", "ModelDescription", "ModelName", "ProductImage", "SnowboardBrandID" },
                values: new object[] { 2, "Freeride, Freestyle- Ideal for backcountry riding.", "x200", "/images/MarkBrandX200.png", 2 });

            migrationBuilder.InsertData(
                table: "Snowboards",
                columns: new[] { "ID", "ModelDescription", "ModelName", "ProductImage", "SnowboardBrandID" },
                values: new object[] { 3, "Splitboard- Split in half for backcountry climbing.", "W40", "/images/MarkBrandW40.jpg", 2 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "CategoryName", "SnowboardID", "UserReview" },
                values: new object[] { 1, " cool board", 1, "This is cool" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "CategoryName", "SnowboardID", "UserReview" },
                values: new object[] { 2, " latino board", 1, "hated it" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "CategoryName", "SnowboardID", "UserReview" },
                values: new object[] { 3, " bear board", 3, "Decent yo" });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_SnowboardID",
                table: "Reviews",
                column: "SnowboardID");

            migrationBuilder.CreateIndex(
                name: "IX_Snowboards_SnowboardBrandID",
                table: "Snowboards",
                column: "SnowboardBrandID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Snowboards");

            migrationBuilder.DropTable(
                name: "SnowboardBrands");
        }
    }
}
