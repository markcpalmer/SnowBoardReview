using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Review",
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
                    table.PrimaryKey("PK_Review", x => x.ReviewID);
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
                    ProductImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snowboards", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SnowboardBrand",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Brand = table.Column<string>(nullable: true),
                    SnowboardID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnowboardBrand", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SnowboardBrand_Snowboards_SnowboardID",
                        column: x => x.SnowboardID,
                        principalTable: "Snowboards",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SnowboardReview",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SnowboardID = table.Column<int>(nullable: false),
                    ReviewID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnowboardReview", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SnowboardReview_Review_ReviewID",
                        column: x => x.ReviewID,
                        principalTable: "Review",
                        principalColumn: "ReviewID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SnowboardReview_Snowboards_SnowboardID",
                        column: x => x.SnowboardID,
                        principalTable: "Snowboards",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SnowboardBrand_SnowboardID",
                table: "SnowboardBrand",
                column: "SnowboardID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SnowboardReview_ReviewID",
                table: "SnowboardReview",
                column: "ReviewID");

            migrationBuilder.CreateIndex(
                name: "IX_SnowboardReview_SnowboardID",
                table: "SnowboardReview",
                column: "SnowboardID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SnowboardBrand");

            migrationBuilder.DropTable(
                name: "SnowboardReview");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Snowboards");
        }
    }
}
