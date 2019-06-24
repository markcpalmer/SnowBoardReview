using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnowBoardReview.Models
{
    public class Review
    {
        public virtual string CategoryName { get; set; }
        public virtual int ReviewID { get; set; }
        public virtual string UserReview { get; set; }

        public virtual List<SnowboardReview> SnowboardReviews { get; set; }

        public Review()
        {

        }

    }
        
}
