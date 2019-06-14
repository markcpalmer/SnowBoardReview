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
        public ViewResult Index()
        {
            ReviewRepository reviews = new ReviewRepository();
            var model = reviews.GetAll();
            return View(model);
        }
    }
}
