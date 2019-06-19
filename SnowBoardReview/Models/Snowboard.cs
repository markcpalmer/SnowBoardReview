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
        public string BrandName { get; set; }
        //public int ReviewID { get; set; }
        //public string UserReview { get; set; }
        public string ProductImage { get; set; }

        public Snowboard(int id, string modelDescription, string modelName, string brandName, string productImage)
        {
            ID = id;
            ModelDescription = modelDescription;
            ModelName = modelName;
            BrandName = brandName;
            ProductImage = productImage;
        }
    }
}
