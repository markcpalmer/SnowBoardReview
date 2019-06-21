using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SnowBoardReview.Models;
using SnowBoardReview.Repositories;

namespace SnowBoardReview.Controllers
{
    public class HomeController: Controller
    {
        ReviewRepository revs = new ReviewRepository();
        SnowBoardReviews sbr = new SnowBoardReviews();
        public ViewResult Index()
        {
            var model = revs.GetAll();
                return View(model);
        }
    }
}
