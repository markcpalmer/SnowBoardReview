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
    public class ReviewControllerTests
    {
        ReviewController underTest;
        IRepository<Review> reviewRepo;

        public ReviewControllerTests()
        {
            reviewRepo = Substitute.For<IRepository<Review>>();

            underTest = new ReviewController(reviewRepo);
        }


        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index(3);

            Assert.IsType<ViewResult>(result);
        }


        [Fact]
        public void Index_Passes_All_Courses_To_View()
        {
            var expectedReview = new List<Review>();

            reviewRepo.GetAll().Returns(expectedReview);

            var result = underTest.Index(2);

            Assert.Equal(expectedReview, result.Model);
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
            var expectedReview = new Review();

            reviewRepo.GetById(1).Returns(expectedReview);

            var result = underTest.Details(1);

            Assert.Equal(expectedReview, result.Model);
        }
    }
}
