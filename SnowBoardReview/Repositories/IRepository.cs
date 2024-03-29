﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnowBoardReview.Models;

namespace SnowBoardReview.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int Id);
        IEnumerable<T> GetByBrandId(int Id);
        void Create(T obj);

        void Delete(T obj);

        void Edit(T obj);
    }




}
