using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnowBoardReview.Models
{
    public class Review
    {
       // public string ProductDescription { get; set; }
       // public string ProductName { get; set; }
        public virtual string CategoryName { get; set; }
        public virtual int ReviewID { get; set; }
        public virtual string UserReview { get; set; }
       // public string ProductImage { get; set; }

        public virtual List<SnowboardReview> SnowboardReviews { get; set; }

        //public Review(string productDescription, string productName, string categoryName, int reviewID, string userReview, string productImage)
        //{
        //    //ProductDescription = productDescription;
        //   // ProductName = productName;
        //    CategoryName = categoryName;
        //    ReviewID = reviewID;
        //    UserReview = userReview;
        //   // ProductImage = productImage;
        //}

        public Review()
        {

        }

        //Crud Application addition


    }
        
}
