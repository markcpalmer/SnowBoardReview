using SnowBoardReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnowBoardReview.Repositories
{
    public class SnowboardRepository : IRepository<Snowboard>
    {
        private SnowBoardContext db;

        public SnowboardRepository(SnowBoardContext db)
        {
            this.db = db;
        }

        public IEnumerable<Snowboard> GetAll()
        {
            return db.Snowboards;
        }

        public Snowboard GetById(int Id)
        {
            return db.Snowboards.Single(r => r.ID == Id);
        }

        public Snowboard GetByBrandId(int Id)
        {
            return db.Snowboards.Single(r => r.SnowboardBrandID == Id);
        }

    }
}
