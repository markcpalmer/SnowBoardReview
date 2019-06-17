using SnowBoardReview.Controllers;
using SnowBoardReview.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace SnowBoardReview.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestIfGetAllWorks()
        {
            ReviewRepository rv = new ReviewRepository();
            IEnumerable<Review> revs = rv.GetAll();
        }
    }
}
