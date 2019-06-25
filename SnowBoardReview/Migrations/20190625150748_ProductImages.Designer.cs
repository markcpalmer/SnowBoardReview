﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SnowBoardReview;

namespace SnowBoardReview.Migrations
{
    [DbContext(typeof(SnowBoardContext))]
    [Migration("20190625150748_ProductImages")]
    partial class ProductImages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SnowBoardReview.Models.Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<string>("UserReview");

                    b.HasKey("ReviewID");

                    b.ToTable("Reviews");

                    b.HasData(
                        new { ReviewID = 1, CategoryName = " cool board", UserReview = "This is cool" },
                        new { ReviewID = 2, CategoryName = " latino board", UserReview = "hated it" },
                        new { ReviewID = 3, CategoryName = " bear board", UserReview = "Decent yo" }
                    );
                });

            modelBuilder.Entity("SnowBoardReview.Models.Snowboard", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ModelDescription");

                    b.Property<string>("ModelName");

                    b.Property<string>("ProductImage");

                    b.Property<int>("ReviewID");

                    b.Property<int>("SnowboardBrandID");

                    b.HasKey("ID");

                    b.HasIndex("ReviewID");

                    b.HasIndex("SnowboardBrandID");

                    b.ToTable("Snowboards");

                    b.HasData(
                        new { ID = 1, ModelDescription = "", ModelName = "Kaleidoscope", ProductImage = "/images/BurtonKaleidoscope.png", ReviewID = 2, SnowboardBrandID = 1 },
                        new { ID = 2, ModelDescription = "blue", ModelName = "x200", ProductImage = "/images/MarkBrandX200.png", ReviewID = 1, SnowboardBrandID = 2 },
                        new { ID = 3, ModelDescription = "red", ModelName = "W40", ProductImage = "/images/MarkBrandW40.jpg", ReviewID = 3, SnowboardBrandID = 2 }
                    );
                });

            modelBuilder.Entity("SnowBoardReview.Models.SnowboardBrand", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<string>("BrandImage");

                    b.HasKey("ID");

                    b.ToTable("SnowboardBrands");

                    b.HasData(
                        new { ID = 1, Brand = "Burton", BrandImage = "/images/burton.jpeg" },
                        new { ID = 2, Brand = "Mark's Brand", BrandImage = "/images/BPowerLogo.png" },
                        new { ID = 3, Brand = "K2", BrandImage = "/images/K2Logo.png" }
                    );
                });

            modelBuilder.Entity("SnowBoardReview.Models.Snowboard", b =>
                {
                    b.HasOne("SnowBoardReview.Models.Review", "Review")
                        .WithMany("Snowboards")
                        .HasForeignKey("ReviewID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SnowBoardReview.Models.SnowboardBrand", "SnowboardBrand")
                        .WithMany("Snowboards")
                        .HasForeignKey("SnowboardBrandID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
