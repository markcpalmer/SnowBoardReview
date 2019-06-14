using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnowBoardReview.Models;

namespace SnowBoardReview.Controllers
{
    public class HomeController: Controller
    {
        //public Review(string productDescription, string productName, string categoryName, int reviewID, string userReview, string productImage)
        public ViewResult Index()
        {
            Review userReview = new Review("a snowBoard", "snowboard 1", "freestyle", 100, "great board for parks", "fake img");
            return View(userReview);
        }
    }
}
