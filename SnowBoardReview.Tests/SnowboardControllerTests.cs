using System;
using System.Collections.Generic;
using System.Text;
using NSubstitute;
using Xunit;
using SnowBoardReview.Controllers;
using SnowBoardReview.Repositories;
using SnowBoardReview.Models;
using Microsoft.AspNetCore.Mvc;


namespace SnowBoardReview.Tests
{
    public class SnowboardControllerTests
    {
        SnowboardController underTest;
        IRepository<Snowboard> snowboardRepo;

        public SnowboardControllerTests()
        {
            snowboardRepo = Substitute.For<IRepository<Snowboard>>();

            underTest = new SnowboardController(snowboardRepo);
        }


        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }


        [Fact]
        public void Index_Passes_All_Courses_To_View()
        {
            var expectedSnowboard = new List<Snowboard>();

            snowboardRepo.GetAll().Returns(expectedSnowboard);

            var result = underTest.Index();

            Assert.Equal(expectedSnowboard, result.Model);
        }


        [Fact]
        public void Details_Returns_A_View()
        {
            var result = underTest.Details(1);

            Assert.IsType<ViewResult>(result);
        }



        [Fact]
        public void Details_Passes_Course_To_View()
        {
            var expectedSnowboard = new Snowboard();

            snowboardRepo.GetById(1).Returns(expectedSnowboard);

            var result = underTest.Details(1);

            Assert.Equal(expectedSnowboard, result.Model);
        }
    }
}
