using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using SnowBoardReview.Controllers;
using Xunit;

namespace SnowBoardReview.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_View()
        {
            var underTest = new HomeController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        //[Fact]
        //public void Details_Returns_View()
        //{
        //    var undertest = new HomeController();

        //    var result = undertest.Details(1);

        //    Assert.IsType<ViewResult>(result);
        //}
    }
}
