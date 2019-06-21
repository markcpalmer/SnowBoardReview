using SnowBoardReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnowBoardReview.Repositories
{
    public class SnowboardReviewRepository : IRepository<SnowboardReview>
    {
        private SnowBoardContext db;

        public SnowboardReviewRepository(SnowBoardContext db)
        {
            this.db = db;
        }

        public IEnumerable<SnowboardReview> GetAll()
        {
            return db.SnowboardReviews;
        }

        public SnowboardReview GetById(int Id)
        {
            return db.SnowboardReviews.Single(r => r.ID == Id);
        }
    }
}
