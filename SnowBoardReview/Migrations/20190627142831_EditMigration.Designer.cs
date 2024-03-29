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
    [Migration("20190627142831_EditMigration")]
    partial class EditMigration
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

                    b.Property<int>("BoardID");

                    b.Property<string>("CategoryName");

                    b.Property<string>("UserReview");

                    b.HasKey("ReviewID");

                    b.HasIndex("BoardID");

                    b.ToTable("Reviews");

                    b.HasData(
                        new { ReviewID = 1, BoardID = 1, CategoryName = " cool board", UserReview = "This is cool" },
                        new { ReviewID = 2, BoardID = 1, CategoryName = " latino board", UserReview = "hated it" },
                        new { ReviewID = 3, BoardID = 3, CategoryName = " bear board", UserReview = "Decent yo" }
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

                    b.Property<int>("SnowboardBrandID");

                    b.HasKey("ID");

                    b.HasIndex("SnowboardBrandID");

                    b.ToTable("Snowboards");

                    b.HasData(
                        new { ID = 1, ModelDescription = "All Mountain, Freestyle- Light, short and flexible", ModelName = "Kaleidoscope", ProductImage = "/images/BurtonKaleidoscope.jpg", SnowboardBrandID = 1 },
                        new { ID = 2, ModelDescription = "Freeride, Freestyle- Ideal for backcountry riding.", ModelName = "x200", ProductImage = "/images/MarkBrandX200.png", SnowboardBrandID = 2 },
                        new { ID = 3, ModelDescription = "Splitboard- Split in half for backcountry climbing.", ModelName = "W40", ProductImage = "/images/MarkBrandW40.jpg", SnowboardBrandID = 2 },
                        new { ID = 4, ModelDescription = "It has a shark painted on it! what more is there to say?", ModelName = "Shark", ProductImage = "/images/k2shark.jpg", SnowboardBrandID = 3 },
                        new { ID = 5, ModelDescription = "The board that put us on the map!! For shredding and back country climbing", ModelName = "K2 Standard", ProductImage = "/images/K2board.jpg", SnowboardBrandID = 3 },
                        new { ID = 6, ModelDescription = "Customized to your liking!! Shred or backcountry...your choose!!", ModelName = "Burton Custom", ProductImage = "/images/burtoncustom2.jpeg", SnowboardBrandID = 1 }
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
                        new { ID = 3, Brand = "K2", BrandImage = "/images/K2_1.png" }
                    );
                });

            modelBuilder.Entity("SnowBoardReview.Models.Review", b =>
                {
                    b.HasOne("SnowBoardReview.Models.Snowboard", "Board")
                        .WithMany("Reviews")
                        .HasForeignKey("BoardID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SnowBoardReview.Models.Snowboard", b =>
                {
                    b.HasOne("SnowBoardReview.Models.SnowboardBrand", "SnowboardBrand")
                        .WithMany("Snowboards")
                        .HasForeignKey("SnowboardBrandID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
