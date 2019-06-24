using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnowBoardReview.Models;
using SnowBoardReview.Repositories;

namespace SnowBoardReview.Controllers
{
    public class SnowboardController : Controller
    {
        IRepository<Snowboard> snowboardRepo;


        public SnowboardController(IRepository<Snowboard> snowboardRepo)
        {
            this.snowboardRepo = snowboardRepo;
        }

        public ViewResult Index()
        {
            var model = snowboardRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = snowboardRepo.GetById(id);
            return View(model);
        }

        public ViewResult Brand(int Id)
        {
            var model = snowboardRepo.GetByBrandId(Id);
           return View(model);
        }
    }
}