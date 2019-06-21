using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnowBoardReview.Models;
using SnowBoardReview.Repositories;

namespace SnowBoardReview.Controllers
{
    public class ReviewController : Controller
    {
        IRepository<Review> reviewRepo;
        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        public ViewResult Index()
        {
            var model = reviewRepo.GetAll();
            return View(model);
        }
    }
}