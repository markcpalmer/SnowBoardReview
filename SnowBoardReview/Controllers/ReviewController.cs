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

        public ViewResult Details(int id)
        {
            var model = reviewRepo.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult Create(int id)
        {
            ViewBag.SnowBoardId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Review review)
        {
            //review.ReviewID = 1;  this is automatically being added.

            reviewRepo.Create(review);

            return RedirectToAction("../Review/Index/" + review.BoardID);
        }

        public ViewResult Index(int Id)
        {
            var model = reviewRepo.GetByBrandId(Id);
            return View(model);
        }
        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = reviewRepo.GetById(id);
            // ViewBag.ReviewId = id;
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Review review)
        {
            //review.ReviewID = 1;  this is automatically being added.
            int rbid = review.BoardID;
            reviewRepo.Delete(review);

            return RedirectToAction("../Review/Index/" + rbid);
        }
    }
}