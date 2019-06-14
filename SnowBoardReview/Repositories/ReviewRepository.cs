using SnowBoardReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SnowBoardReview.Controllers
{

    public class ReviewRepository
    {
        public List<Review> reviewList = new List<Review>()
        {

         new Review("a snowboard", "Board1", "snowboards", 1, "Its pretty good", "FakeIMG"),
         new Review("a snowboard", "Board2", "snowboards", 2, "Its okay", "FakeIMG"),
         new Review("a snowboard", "Board3", "snowboards", 3, "Luis said It sucks really bad", "FakeIMG"),
         new Review("a snowboard", "Board4", "snowboards", 4, "Matt and Mark recommend", "FakeIMG"),

        };

        public IEnumerable<Review> GetAll()
        {
            return reviewList;
        }

        public Review GetByID(int Id)
        {
            return reviewList.Single(r => r.ReviewID == Id);
        }
    }   

        
}
