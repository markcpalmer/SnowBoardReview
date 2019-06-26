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
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Review review)
        {
            //review.ReviewID = 1;  this is automatically being added.

            reviewRepo.Create(review);

            return RedirectToAction("Index");
        }

        public ViewResult Index(int Id)
        {
            var model = reviewRepo.GetByBrandId(Id);
            return View(model);
        }
        [HttpGet]
        public ViewResult Delete(int id)
        {
            ViewBag.ReviewId =id;
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Review review)
        {
            //review.ReviewID = 1;  this is automatically being added.

            reviewRepo.Delete(review);

            return RedirectToAction("Index");
        }
    }
}