using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnowBoardReview.Models;

namespace SnowBoardReview.Data
{
    public class DbInitializer
    {
        public static void Initialize(SnowBoardContext context)
        {
            var rev = new Review("gnarly", "TooCool", "Board", 1, "That's cool", "img123");
            context.Add<Review>(rev);
        }


    }
}
