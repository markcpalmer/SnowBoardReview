using SnowBoardReview.Models;
using SnowBoardReview.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SnowBoardReview.Controllers
{

    public class ReviewRepository : IRepository<Review>
    {
        SnowBoardContext db = new SnowBoardContext();

        public IEnumerable<Review> GetAll() 
        {
            return db.Reviews;
        }

        public Review GetById(int Id)
        {
            return db.Reviews.Single(r => r.ReviewID == Id);
        }
    }           
}
