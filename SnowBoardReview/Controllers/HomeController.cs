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
        //public Review(string productDescription, string productName, string categoryName, int reviewID, string userReview, string productImage)
        SnowBoardContext context = new SnowBoardContext();
        //ReviewRepository reviews = new ReviewRepository();
        public ViewResult Index()
        {

            var model = context.GetAll();
           return View(model);
        }

        //public ViewResult Details(int id)
        //{
        //    var model = reviews.GetById(id);
        //    return View(model);
        //}

       // public ActionResult Index()
       // {
       //     return View();
       // }

        //public async Task<IActionResult> Indextwo()
        //{
        //    return View(await context.Snowboards.ToListAsync());
        //} 


    }
}
