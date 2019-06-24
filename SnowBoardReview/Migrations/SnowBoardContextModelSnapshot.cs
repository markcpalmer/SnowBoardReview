﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SnowBoardReview;

namespace SnowBoardReview.Migrations
{
    [DbContext(typeof(SnowBoardContext))]
    partial class SnowBoardContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("SnowboardBrandID");

                    b.HasKey("ID");

                    b.HasIndex("SnowboardBrandID");

                    b.ToTable("Snowboards");

                    b.HasData(
                        new { ID = 1, ModelDescription = "", ModelName = "William", ProductImage = "Shakespeare", SnowboardBrandID = 1 },
                        new { ID = 2, ModelDescription = "blue", ModelName = "x200", ProductImage = "tree", SnowboardBrandID = 2 },
                        new { ID = 3, ModelDescription = "red", ModelName = "W40", ProductImage = "water", SnowboardBrandID = 2 }
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
                        new { ID = 2, Brand = "Mark's Brand", BrandImage = "/images/Marksboard.png" },
                        new { ID = 3, Brand = "K2", BrandImage = "/images/K2Logo.png" }
                    );
                });

            modelBuilder.Entity("SnowBoardReview.Models.SnowboardReview", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ReviewID");

                    b.Property<int>("SnowboardID");

                    b.HasKey("ID");

                    b.HasIndex("ReviewID");

                    b.HasIndex("SnowboardID");

                    b.ToTable("SnowboardReviews");

                    b.HasData(
                        new { ID = 1, ReviewID = 1, SnowboardID = 1 },
                        new { ID = 2, ReviewID = 2, SnowboardID = 3 },
                        new { ID = 3, ReviewID = 3, SnowboardID = 2 }
                    );
                });

            modelBuilder.Entity("SnowBoardReview.Models.Snowboard", b =>
                {
                    b.HasOne("SnowBoardReview.Models.SnowboardBrand", "SnowboardBrand")
                        .WithMany("Snowboards")
                        .HasForeignKey("SnowboardBrandID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SnowBoardReview.Models.SnowboardReview", b =>
                {
                    b.HasOne("SnowBoardReview.Models.Review", "Review")
                        .WithMany("SnowboardReviews")
                        .HasForeignKey("ReviewID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SnowBoardReview.Models.Snowboard", "Snowboard")
                        .WithMany("SnowboardReviews")
                        .HasForeignKey("SnowboardID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
