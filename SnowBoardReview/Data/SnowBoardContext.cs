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

            optionsBuilder.UseSqlServer(connectionString);
                      //  .UseLazyLoadingProxies();

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
                    ProductImage  = "Shakespeare"
                }
            );
        }
    }
}
