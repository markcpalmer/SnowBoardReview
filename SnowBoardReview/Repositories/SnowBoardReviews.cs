using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnowBoardReview.Models;

namespace SnowBoardReview.Repositories
{
    public class SnowBoardReviews : IRepository<SnowboardReview>
    {
        SnowBoardContext db = new SnowBoardContext();

        public IEnumerable<SnowboardReview> GetAll()
        {
            return db.SnowboardReviews;
        }

        public SnowboardReview GetById(int Id)
        {
            return db.SnowboardReviews.Single(r => r.ReviewID == Id);
        }

    }
}
