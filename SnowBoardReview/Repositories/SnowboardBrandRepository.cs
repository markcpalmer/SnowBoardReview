using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnowBoardReview.Models;

namespace SnowBoardReview.Repositories
{
    public class SnowboardBrandRepository : IRepository<SnowboardBrand>
    {

            private SnowBoardContext db;

            public SnowboardBrandRepository(SnowBoardContext db)
            {
                this.db = db;
            }

            public IEnumerable<SnowboardBrand> GetAll()
            {
                return db.SnowboardBrands;
            }

        public SnowboardBrand GetByBrandId(int Id)
        {
            throw new NotImplementedException();
        }

        public SnowboardBrand GetById(int Id)
            {
                return db.SnowboardBrands.Single(r => r.ID == Id);
            }

        
    }
            
}
