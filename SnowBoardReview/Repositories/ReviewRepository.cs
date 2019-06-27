using SnowBoardReview.Models;
using SnowBoardReview.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SnowBoardReview.Repositories
{

    public class ReviewRepository : IRepository<Review>
    {

        private SnowBoardContext db;

        public ReviewRepository(SnowBoardContext db)
        {
            this.db = db;
        }

        public IEnumerable<Review> GetAll() 
        {
            return db.Reviews;
        }

        public IEnumerable<Review> GetByBrandId(int Id)
        {
            return db.Reviews.Where(r => r.BoardID == Id);
        }

        public Review GetById(int Id)
        {
            return db.Reviews.Single(r => r.ReviewID == Id);
        }

        public void Create(Review review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
        }
        public void Delete(Review review)
        {
            db.Reviews.Remove(review);
            db.SaveChanges(); 
        }
        public void Edit(Review review)
        {
            db.Reviews.Update(review);
            db.SaveChanges();
        }

    }    

}
