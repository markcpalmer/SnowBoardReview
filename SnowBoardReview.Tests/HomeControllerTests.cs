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
        public void Index_Returns_Hello_World()
        {
            var underTest = new HomeController();

            var result = underTest.Index();

            Assert.Equal("Hello World!", result);
        }
    }
}
