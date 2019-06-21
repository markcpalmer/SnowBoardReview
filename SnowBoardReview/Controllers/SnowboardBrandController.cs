using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnowBoardReview.Models;
using SnowBoardReview.Repositories;

namespace SnowBoardReview.Controllers
{
    public class SnowboardBrandController : Controller
    {
        IRepository<SnowboardBrand> brandRepo;
        public SnowboardBrandController(IRepository<SnowboardBrand> brandRepo)
        {
            this.brandRepo = brandRepo;
        }

        public ViewResult Index()
        {
            var model = brandRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = brandRepo.GetById(id);
            return View(model);
        }
    }
}