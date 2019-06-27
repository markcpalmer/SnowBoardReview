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

        public ViewResult AllReviews()
        {
            var model = reviewRepo.GetAll();
            return View(model);
        }
        
        public ViewResult Details(int id)
        {
            var model = reviewRepo.GetById(id);
            return View(model);
        }

        public ViewResult Index(int Id)
        {
            var model = reviewRepo.GetByBrandId(Id);
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
            reviewRepo.Create(review);

            return RedirectToAction("../Review/Index/" + review.BoardID);
        }


        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = reviewRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Review review)
        {
            int rbid = review.BoardID;
            reviewRepo.Delete(review);

            return RedirectToAction("../Review/Index/" + rbid);
        }



        [HttpGet]
        public ViewResult Edit(int id)
        {
            ViewBag.SnowBoardId = id;

            var model = reviewRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Review review)
        {
            int rbid = review.BoardID;
            reviewRepo.Edit(review);

            return RedirectToAction("../Review/Index/" + rbid);
        }
    }
}