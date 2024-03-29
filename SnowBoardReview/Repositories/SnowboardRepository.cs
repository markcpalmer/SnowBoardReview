﻿using SnowBoardReview.Models;
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

        public IEnumerable<Snowboard> GetByBrandId(int Id)
        {
            return db.Snowboards.Where(r => r.SnowboardBrandID == Id);
        }

        public void Create(Snowboard obj)
        {
            throw new NotImplementedException();
        }
        public void Delete(Snowboard obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Snowboard obj)
        {
            throw new NotImplementedException();
        }
    }
}
