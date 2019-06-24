using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnowBoardReview.Models
{
    public class Snowboard
    {
        public virtual int ID { get; set; }
        public virtual string ModelDescription { get; set; }
        public virtual string ModelName { get; set; }
        public virtual string ProductImage { get; set; }

        public virtual SnowboardBrand SnowboardBrand { get; set; }
        public int SnowboardBrandID { get; set; }

        public virtual List<SnowboardReview> SnowboardReviews { get; set; }

        //public  Snowboard(string modelDescription, string modelName, string productImage)
        //{
        //    ModelDescription = modelDescription;
        //    ModelName = modelName;
        //    ProductImage = productImage;
        //}

        public Snowboard()
        {

        }
    }
}
