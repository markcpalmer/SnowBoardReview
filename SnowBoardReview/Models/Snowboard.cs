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

        public SnowboardBrand SnowboardBrand { get; set; }
        public int SnowboardBrandID { get; set; }

        public virtual List<SnowboardReview> SnowboardReviews { get; set; }

        public Snowboard(string modelDescription, string modelName, string productImage)
        {
            ModelDescription = modelDescription;
            ModelName = modelName;
            ProductImage = productImage;
        }
        public Snowboard()
        {

        }
    }
}
