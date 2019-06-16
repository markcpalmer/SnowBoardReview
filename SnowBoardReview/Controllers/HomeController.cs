using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnowBoardReview.Models;
using SnowBoardReview.Repositories;

namespace SnowBoardReview.Controllers
{
    public class HomeController: Controller
    {
        //public Review(string productDescription, string productName, string categoryName, int reviewID, string userReview, string productImage)
        ReviewRepository reviews = new ReviewRepository();
        public ViewResult Index()
        {
            
            var model = reviews.GetAll();
            return View(model);
        }

        public ViewResult Details(int i)
        {
            i = ReviewID - 1;
            var model = reviews.GetById(i);
            return View(model);
        }


    }
}
