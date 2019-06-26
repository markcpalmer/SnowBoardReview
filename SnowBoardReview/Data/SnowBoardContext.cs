using Microsoft.EntityFrameworkCore;
using SnowBoardReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnowBoardReview
{
    public class SnowBoardContext : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Snowboard> Snowboards { get; set; }
        public DbSet<SnowboardBrand> SnowboardBrands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=SnowBoardTesting;Trusted_Connection=True";

            optionsBuilder.UseSqlServer(connectionString)
                        .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Snowboard>().HasData(
                new Snowboard
                {
                    ID = 1,
                    ModelDescription = "All Mountain, Freestyle- Light, short and flexible",
                    ModelName = "Kaleidoscope",
                    ProductImage = "/images/BurtonKaleidoscope.jpg",
                    SnowboardBrandID = 1,
                },
                new Snowboard
                {
                    ID = 2,
                    ModelDescription = "Freeride, Freestyle- Ideal for backcountry riding.",
                    ModelName = "x200",
                    ProductImage = "/images/MarkBrandX200.png",
                    SnowboardBrandID = 2,
                },
                new Snowboard
                {
                    ID = 3,
                    ModelDescription = "Splitboard- Split in half for backcountry climbing.",
                    ModelName = "W40",
                    ProductImage = "/images/MarkBrandW40.jpg",
                    SnowboardBrandID = 2,
                },
                 new Snowboard
                 {
                     ID = 4,
                     ModelDescription = "It has a shark painted on it! what more is there to say?",
                     ModelName = "Shark",
                     ProductImage = "/images/k2shark.jpg",
                     SnowboardBrandID = 3,
                 },
                  new Snowboard
                  {
                      ID = 5,
                      ModelDescription = "The board that put us on the map!! For shredding and back country climbing",
                      ModelName = "K2 Standard",
                      ProductImage = "/images/K2board.jpg",
                      SnowboardBrandID = 3,
                  },
                  new Snowboard
                  {
                      ID = 6,
                      ModelDescription = "Customized to your liking!! Shred or backcountry...your choose!!",
                      ModelName = "Burton Custom",
                      ProductImage = "/images/burtoncustom2.jpeg",
                      SnowboardBrandID = 1,

                  });

            modelBuilder.Entity<Review>().HasData(
                 new Review
                 {
                     ReviewID = 1,
                     CategoryName = " cool board",
                     UserReview = "This is cool",
                     SnowboardID = 1,
                 },
               new Review
               {
                   ReviewID = 2,
                   CategoryName = " latino board",
                   UserReview = "hated it",
                   SnowboardID =1,
               },
                new Review
                {
                    ReviewID = 3,
                    CategoryName = " bear board",
                    UserReview = "Decent yo",
                    SnowboardID=3,
                });


            modelBuilder.Entity<SnowboardBrand>().HasData(
               new SnowboardBrand
               {
                   ID = 1,
                   Brand = "Burton",
                   BrandImage = "/images/burton.jpeg"
               },
               new SnowboardBrand
               {
                   ID = 2,
                   Brand = "Mark's Brand",
                   BrandImage = "/images/BPowerLogo.png"

               },
               new SnowboardBrand
               {
                   ID = 3,
                   Brand = "K2",
                   BrandImage = "/images/K2_1.png"
               });
        }
    }
}
