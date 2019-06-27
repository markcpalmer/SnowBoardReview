using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SnowBoardReview.Controllers;
using SnowBoardReview.Repositories;
using SnowBoardReview.Models;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;


namespace SnowBoardReview.Tests
{
    public class SnowboardBrandControllerTests
    {
        SnowboardBrandController underTest;
        IRepository<SnowboardBrand> brandRepo;

        public SnowboardBrandControllerTests()
        {
            brandRepo = Substitute.For<IRepository<SnowboardBrand>>();

            underTest = new SnowboardBrandController(brandRepo);
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
            var expectedBrand = new List<SnowboardBrand>();

            brandRepo.GetAll().Returns(expectedBrand);

            var result = underTest.Index();

            Assert.Equal(expectedBrand, result.Model);
        }


        [Fact]
        public void Details_Returns_A_View()
        {
            var result = underTest.Details(2);

            Assert.IsType<ViewResult>(result);
        }



        [Fact]
        public void Details_Passes_Course_To_View()
        {
            var expectedBrand = new SnowboardBrand();

            brandRepo.GetById(1).Returns(expectedBrand);

            var result = underTest.Details(1);

            Assert.Equal(expectedBrand, result.Model);
        }

    }
}
