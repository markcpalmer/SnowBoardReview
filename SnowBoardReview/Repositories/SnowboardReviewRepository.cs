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

        public void Create(SnowboardReview obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SnowboardReview> GetAll()
        {
            return db.SnowboardReviews;
        }

        public IEnumerable<SnowboardReview> GetByBrandId(int Id)
        {
            throw new NotImplementedException();
        }

        public SnowboardReview GetById(int Id)
        {
            return db.SnowboardReviews.Single(r => r.ID == Id);
        }
    }
}
