using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnowBoardReview.Models
{
    public class Review
    {
        public string CategoryName { get; set; }
        public int ReviewID { get; set; }
        public string UserReview { get; set; }

        public virtual Snowboard Snowboard { get; set; }
        public virtual int SnowboardID { get; set; }

        public Review()
        {

        }

    }
        
}
