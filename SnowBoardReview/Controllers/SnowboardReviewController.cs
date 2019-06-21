using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SnowBoardReview.Controllers
{
    public class SnowboardReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}