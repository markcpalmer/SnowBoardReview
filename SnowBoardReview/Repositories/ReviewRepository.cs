using SnowBoardReview.Models;
using SnowBoardReview.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SnowBoardReview.Controllers
{

    public class ReviewRepository : IRepository<Review>
    {
        public List<Review> reviewList = new List<Review>()
        {
         new Review("Burton", "Board1", "snowboard one", 1, "TESTERS SAID: THIS IS THE BEST PARK BOARD IVE EVER RIDDEN. THE HEADSPACE IS LIKE THE FIRST TIME YOU DRIVE A REALLY NICE CAR YOU STRAP IN AND SAY TO YOURSELF, THIS IS WHAT A SNOWBOARD IS SUPPOSED TO FEEL LIKE.", "/Images/snowboard1.jpg"),
         new Review("K2", "Board2", "snowboard two", 2, "The Custom Flying V is one of those boards that can ride any style, so it's great if you're after one board to ride the park, groomers, trees and in the backcountry - and however you like to ride in all those areas.", "/Images/snowboard2.jpg"),
         new Review("Forum", "Board3", "snowboard three", 3, "Luis said It sucks really bad.  It's the most narrow board he's ever been on!!", "/Images/snowboard4.jpg"),
         new Review("Lib Tech", "Board4", "snowboard four", 4, "If youve ever seen any of Forest Baileys video parts and you better have then you know hes an individual oozing with style while remaining impossible to categorize. His pro model Headspace is no different. Whether youre mashing slushy berms, pressing through kinks, or sending it to the moon, this deck is ready to handle everything with style. With an asymmetrical design featuring a deeper sidecut along the heel edge along with Mervins signature Magne-Traction and mellow C3 camber profile, the Headspace had our testers ripping through everything from hardpack to slush both in the park and out. ", "/Images/snowboard3.jpg"),
        };

        public IEnumerable<Review> GetAll() 
        {
            return reviewList;
        }

        public Review GetById(int Id)
        {
            return reviewList.Single(r => r.ReviewID == Id);
        }
    }           
}
