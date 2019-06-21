using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnowBoardReview.Models;
using SnowBoardReview.Repositories;

namespace SnowBoardReview.Controllers
{
    public class SnowboardReviewController : Controller
    {
        IRepository<SnowboardReview> snowreviewRepo;
        public SnowboardReviewController(IRepository<SnowboardReview> snowreviewRepo)
        {
            this.snowreviewRepo = snowreviewRepo;
        }

        public ViewResult Index()
        {
            var model = snowreviewRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = snowreviewRepo.GetById(id);
            return View(model);
        }

    }
}