﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SnowBoardReview.Migrations
{
    public partial class burtonfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 6,
                column: "ProductImage",
                value: "/images/BurtonCustom.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snowboards",
                keyColumn: "ID",
                keyValue: 6,
                column: "ProductImage",
                value: "/images/BurtonCustom.jpg");
        }
    }
}
