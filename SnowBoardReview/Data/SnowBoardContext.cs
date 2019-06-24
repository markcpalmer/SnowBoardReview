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
        public DbSet<SnowboardReview> SnowboardReviews { get; set; }

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
                    ModelDescription = "",
                    ModelName = "William",
                    ProductImage = "Shakespeare",
                    SnowboardBrandID = 1
                },
                new Snowboard
                {
                    ID = 2,
                    ModelDescription = "blue",
                    ModelName = "x200",
                    ProductImage = "tree",
                    SnowboardBrandID=2
                },
                new Snowboard
                {
                    ID = 3,
                    ModelDescription = "red",
                    ModelName = "W40",
                    ProductImage = "water",
                    SnowboardBrandID=2
                });

            modelBuilder.Entity<Review>().HasData(
                 new Review
                 {
                     ReviewID = 1,
                    // ProductDescription = "mark",
                    // ProductName = "take 2",
                     CategoryName = " cool board",
                     UserReview = "This is cool",
                     //ProductImage = "Pretty",

                 },
               new Review
               {
                   ReviewID = 2,
                 //  ProductDescription = "luis",
                  // ProductName = "diablo",
                   CategoryName = " latino board",
                   UserReview = "hated it",
                  // ProductImage = "ok",

               },
                new Review
                {
                    ReviewID = 3,
                   // ProductDescription = "matt",
                   // ProductName = "polar bear",
                    CategoryName = " bear board",
                    UserReview = "Decent yo",
                   // ProductImage = "decent still",
                });

            modelBuilder.Entity<SnowboardReview>().HasData(
               new SnowboardReview
               {
                   ID = 1,
                   ReviewID = 1,
                   SnowboardID = 1,
               },
                new SnowboardReview
                {
                    ID = 2,
                    ReviewID =2,
                    SnowboardID = 3,
                },
                new SnowboardReview
                {
                    ID = 3,
                    ReviewID = 3,
                    SnowboardID = 2,
                });

            modelBuilder.Entity<SnowboardBrand>().HasData(
               new SnowboardBrand
               {
                   ID = 1,
                   Brand = "Burton",
               },
               new SnowboardBrand
               {
                   ID = 2,
                   Brand = "Mark's Brand",

               },
               new SnowboardBrand
               {
                   ID = 3,
                   Brand = "K2",
               });
        }
    }
}
