using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnowBoardReview.Models
{
    public class SnowboardBrand
    {
        public virtual int ID { get; set; }
        public virtual string Brand { get; set; }
        public virtual string BrandImage { get; set; }

        public virtual List<Snowboard> Snowboards { get; set; }
    }
}
