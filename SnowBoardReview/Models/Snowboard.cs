using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnowBoardReview.Models
{
    public class Snowboard
    {
        public int ID { get; set; }
        public string ModelDescription { get; set; }
        public string ModelName { get; set; }
        public string ProductImage { get; set; }

        public virtual SnowboardBrand SnowboardBrand { get; set; }
        public int SnowboardBrandID { get; set; }

        public virtual Review Review { get; set; }
        public virtual int ReviewID { get; set; }


        public Snowboard()
        {

        }
    }
}
