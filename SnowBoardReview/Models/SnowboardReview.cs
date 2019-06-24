using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnowBoardReview.Models
{
    public class SnowboardReview
    {
        public virtual int ID { get; set; }

        public virtual Snowboard Snowboard { get; set; }
        public virtual int SnowboardID { get; set; }

        public virtual Review Review { get; set; }
        public virtual int ReviewID { get; set; }
    }
}
