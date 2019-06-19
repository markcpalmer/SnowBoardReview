using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnowBoardReview.Models
{
    public class SnowboardReview
    {
        public int ID { get; set; }

        public Snowboard Snowboard { get; set; }
        public int SnowboardID { get; set; }
        public Review Review { get; set; }
        public int ReviewID { get; set; }
    }
}
