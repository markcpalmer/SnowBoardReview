using SnowBoardReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SnowBoardReview.Data
{
    public class DbInitializer
    {
        public static void Initialize(SnowBoardContext context)
        {
            context.Database.EnsureCreated();

            if (context.Snowboards.Any())
            {
                return;
            }

            var snowboards = new Snowboard[]
            {
                new Snowboard("cool board", "red board", "img123")

            };

            foreach (Snowboard snow in snowboards)
            {
                context.Snowboards.Add(snow);
            }
            context.SaveChanges();

            var snowboardbrand = new SnowboardBrand[]
            {
                new SnowboardBrand{ID=1,Brand="Gnarly"}
            };

            foreach (SnowboardBrand brand in snowboardbrand)
            {
                context.SnowboardBrands.Add(brand);
            }
            context.SaveChanges();


            var review = new Review[]
            {
                new Review("cool thing", "funky board", "snowboards", 1, "this was cool", "imag123")
            };

            foreach (Review view in review)
            {
                context.Reviews.Add(view);
            }
            context.SaveChanges();

        }

    }
}
