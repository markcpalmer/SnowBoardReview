using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnowBoardReview.Models
{
    public class SnowboardBrand
    {
        public int ID { get; set; }
        public string Brand { get; set; }

        public int SnowboardID { get; set; }
    }
}
