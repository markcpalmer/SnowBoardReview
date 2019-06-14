using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnowBoardReview.Repositories
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> getAll();
        T GetById(int Id);




    }
}
