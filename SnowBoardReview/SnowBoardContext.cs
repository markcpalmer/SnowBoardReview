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

        public DbSet<Snowboard> Snowboards { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=SnowBoardTesting;Trusted_Connection=True";

            optionsBuilder.UseSqlServer(connectionString);
                      //  .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);

        }
    }
}
