using System;
using Xunit;
using API_SwitchBack.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using API_SwitchBack.Controllers;
using API_SwitchBack.Models;
using API_SwitchBack.Models.Interfaces;
using API_SwitchBack.Models.Services;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace API_SwitchBack_TDD
{
    public class RouteTesting
    {
        /*
        TrailController _trailController;
        ITrail _trailService;

        public void TrailControllerTest()
        {
            _trailService = new TrailServicesFake();
            _trailController = new TrailController(_trailService);

        }

        //[Fact]
        public void CheckToSeeIfGetIsOK()
        {
            // Arrange

            // Act

            var okResult = _trailController.Get();

            //Assert

            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        //[Fact]
        public void Test1()
        {
            // Arrange

            // Act

            //Assert

        }
        */

        [Fact]
        public void CanGetOneTrailFromOne()
        {
            DbContextOptions<SwitchbackAPIDbContext> options = new DbContextOptionsBuilder<SwitchbackAPIDbContext>().UseInMemoryDatabase("CanCreateCourse").Options;

            using (SwitchbackAPIDbContext context = new SwitchbackAPIDbContext(options))
            {
                // Arrange
                Trail trail1 = new Trail();
                trail1.Name = "Clown Lake Trail";
                trail1.Type = "Featured Hike";
                trail1.Summary = "A great place for a picnic and watching paragliders!";
                trail1.Difficulty = "blue";
                trail1.Stars = 4.3;
                trail1.StarVotes = 50;
                trail1.Location = "Issaquah, Washington";
                trail1.Url = "https://www.hikingproject.com/trail/7005406/poo-poo-point-via-chirico-trail";
                trail1.ImgSqSmall = "https://cdn-files.apstatic.com/hike/7004771_sqsmall_1554310760.jpg";
                trail1.ImgSmall = "https://cdn-files.apstatic.com/hike/7004771_small_1554310760.jpg";
                trail1.ImgSmallMed = "https://cdn-files.apstatic.com/hike/7004771_smallMed_1554310760.jpg";
                trail1.ImgMedium = "https://cdn-files.apstatic.com/hike/7004771_medium_1554310760.jpg";
                trail1.Length = 3.9;
                trail1.Ascent = 1619;
                trail1.Descent = -1618;
                trail1.High = 1807;
                trail1.Low = 188;
                trail1.Longitude = -122.0211;
                trail1.Latitude = 47.4999;
                trail1.ConditionStatus = "All Clear";
                trail1.ConditionDetails = "Dry";
                trail1.ConditionDate = "2019-04-19 11:05:03";

                context.Add(trail1);
                context.SaveChanges();

                // Act
                var result = context.Trail.FirstOrDefault(m => m.TrailID == trail1.TrailID);

                // Assert

                Assert.Equal(result, trail1);


            };
        }

        [Fact]
        public void CanGetOneTrailFromThree_One()
        {
            DbContextOptions<SwitchbackAPIDbContext> options = new DbContextOptionsBuilder<SwitchbackAPIDbContext>().UseInMemoryDatabase("CanCreateCourse").Options;

            using (SwitchbackAPIDbContext context = new SwitchbackAPIDbContext(options))
            {
                // Arrange
                Trail trail1 = new Trail();
                trail1.Name = "Clown Lake Trail";
                trail1.Type = "Featured Hike";
                trail1.Summary = "A great place for a picnic and watching paragliders!";
                trail1.Difficulty = "blue";
                trail1.Stars = 4.3;
                trail1.StarVotes = 50;
                trail1.Location = "Issaquah, Washington";
                trail1.Url = "https://www.hikingproject.com/trail/7005406/poo-poo-point-via-chirico-trail";
                trail1.ImgSqSmall = "https://cdn-files.apstatic.com/hike/7004771_sqsmall_1554310760.jpg";
                trail1.ImgSmall = "https://cdn-files.apstatic.com/hike/7004771_small_1554310760.jpg";
                trail1.ImgSmallMed = "https://cdn-files.apstatic.com/hike/7004771_smallMed_1554310760.jpg";
                trail1.ImgMedium = "https://cdn-files.apstatic.com/hike/7004771_medium_1554310760.jpg";
                trail1.Length = 3.9;
                trail1.Ascent = 1619;
                trail1.Descent = -1618;
                trail1.High = 1807;
                trail1.Low = 188;
                trail1.Longitude = -122.0211;
                trail1.Latitude = 47.4999;
                trail1.ConditionStatus = "All Clear";
                trail1.ConditionDetails = "Dry";
                trail1.ConditionDate = "2019-04-19 11:05:03";

                Trail trail2 = new Trail();
                trail2.Name = "Pie in the Face Trail";
                trail2.Type = "Featured Hike";
                trail2.Summary = "Watchout for Clowns throwing Pies";
                trail2.Difficulty = "Azure";
                trail2.Stars = 2.3;
                trail2.StarVotes = 20;
                trail2.Location = "Clown, Washington";
                trail2.Url = "https://www.hikingproject.com/trail/7005406/pie-face";
                trail2.ImgSqSmall = "https://cdn-files.apstatic.com/hike/7005771_sqsmall_1554310760.jpg";
                trail2.ImgSmall = "https://cdn-files.apstatic.com/hike/7005771_small_1554310760.jpg";
                trail2.ImgSmallMed = "https://cdn-files.apstatic.com/hike/7005771_smallMed_1554310760.jpg";
                trail2.ImgMedium = "https://cdn-files.apstatic.com/hike/7005771_medium_1554310760.jpg";
                trail2.Length = 2.9;
                trail2.Ascent = 1719;
                trail2.Descent = -1218;
                trail2.High = 107;
                trail2.Low = 18;
                trail2.Longitude = -132.0211;
                trail2.Latitude = 47.7999;
                trail2.ConditionStatus = "Pies Everywhere";
                trail2.ConditionDetails = "Slippery";
                trail2.ConditionDate = "2019-04-19 10:05:03";

                Trail trail3 = new Trail();
                trail3.Name = "The Slippery Bannana Trail";
                trail3.Type = "Featured Hike";
                trail3.Summary = "Watch your step, there is bannana peals every where";
                trail3.Difficulty = "Red";
                trail3.Stars = 1.3;
                trail3.StarVotes = 25;
                trail3.Location = "Bananna, Washington";
                trail3.Url = "https://www.hikingproject.com/trail/7005306/slippery-bananna";
                trail3.ImgSqSmall = "https://cdn-files.apstatic.com/hike/7005571_sqsmall_1554311760.jpg";
                trail3.ImgSmall = "https://cdn-files.apstatic.com/hike/7005571_small_1554311760.jpg";
                trail3.ImgSmallMed = "https://cdn-files.apstatic.com/hike/7005571_smallMed_1554311760.jpg";
                trail3.ImgMedium = "https://cdn-files.apstatic.com/hike/7005571_medium_1554311760.jpg";
                trail3.Length = 6.9;
                trail3.Ascent = 2219;
                trail3.Descent = -3218;
                trail3.High = 607;
                trail3.Low = 218;
                trail3.Longitude = -132.9211;
                trail3.Latitude = 46.7999;
                trail3.ConditionStatus = "Bananna peals Everywhere";
                trail3.ConditionDetails = "Slippery";
                trail3.ConditionDate = "2019-04-17 10:05:03";

                context.Add(trail1);
                context.SaveChanges();
                context.Add(trail2);
                context.SaveChanges();
                context.Add(trail3);
                context.SaveChanges();

                // Act
                var result = context.Trail.FirstOrDefault(m => m.TrailID == trail1.TrailID);

                // Assert

                Assert.Equal(result, trail1);


            };
        }

        [Fact]
        public void CanGetOneTrailFromThree_Two()
        {
            DbContextOptions<SwitchbackAPIDbContext> options = new DbContextOptionsBuilder<SwitchbackAPIDbContext>().UseInMemoryDatabase("CanCreateCourse").Options;

            using (SwitchbackAPIDbContext context = new SwitchbackAPIDbContext(options))
            {
                // Arrange
                Trail trail1 = new Trail();
                trail1.Name = "Clown Lake Trail";
                trail1.Type = "Featured Hike";
                trail1.Summary = "A great place for a picnic and watching paragliders!";
                trail1.Difficulty = "blue";
                trail1.Stars = 4.3;
                trail1.StarVotes = 50;
                trail1.Location = "Issaquah, Washington";
                trail1.Url = "https://www.hikingproject.com/trail/7005406/poo-poo-point-via-chirico-trail";
                trail1.ImgSqSmall = "https://cdn-files.apstatic.com/hike/7004771_sqsmall_1554310760.jpg";
                trail1.ImgSmall = "https://cdn-files.apstatic.com/hike/7004771_small_1554310760.jpg";
                trail1.ImgSmallMed = "https://cdn-files.apstatic.com/hike/7004771_smallMed_1554310760.jpg";
                trail1.ImgMedium = "https://cdn-files.apstatic.com/hike/7004771_medium_1554310760.jpg";
                trail1.Length = 3.9;
                trail1.Ascent = 1619;
                trail1.Descent = -1618;
                trail1.High = 1807;
                trail1.Low = 188;
                trail1.Longitude = -122.0211;
                trail1.Latitude = 47.4999;
                trail1.ConditionStatus = "All Clear";
                trail1.ConditionDetails = "Dry";
                trail1.ConditionDate = "2019-04-19 11:05:03";

                Trail trail2 = new Trail();
                trail2.Name = "Pie in the Face Trail";
                trail2.Type = "Featured Hike";
                trail2.Summary = "Watchout for Clowns throwing Pies";
                trail2.Difficulty = "Azure";
                trail2.Stars = 2.3;
                trail2.StarVotes = 20;
                trail2.Location = "Clown, Washington";
                trail2.Url = "https://www.hikingproject.com/trail/7005406/pie-face";
                trail2.ImgSqSmall = "https://cdn-files.apstatic.com/hike/7005771_sqsmall_1554310760.jpg";
                trail2.ImgSmall = "https://cdn-files.apstatic.com/hike/7005771_small_1554310760.jpg";
                trail2.ImgSmallMed = "https://cdn-files.apstatic.com/hike/7005771_smallMed_1554310760.jpg";
                trail2.ImgMedium = "https://cdn-files.apstatic.com/hike/7005771_medium_1554310760.jpg";
                trail2.Length = 2.9;
                trail2.Ascent = 1719;
                trail2.Descent = -1218;
                trail2.High = 107;
                trail2.Low = 18;
                trail2.Longitude = -132.0211;
                trail2.Latitude = 47.7999;
                trail2.ConditionStatus = "Pies Everywhere";
                trail2.ConditionDetails = "Slippery";
                trail2.ConditionDate = "2019-04-19 10:05:03";

                Trail trail3 = new Trail();
                trail3.Name = "The Slippery Bannana Trail";
                trail3.Type = "Featured Hike";
                trail3.Summary = "Watch your step, there is bannana peals every where";
                trail3.Difficulty = "Red";
                trail3.Stars = 1.3;
                trail3.StarVotes = 25;
                trail3.Location = "Bananna, Washington";
                trail3.Url = "https://www.hikingproject.com/trail/7005306/slippery-bananna";
                trail3.ImgSqSmall = "https://cdn-files.apstatic.com/hike/7005571_sqsmall_1554311760.jpg";
                trail3.ImgSmall = "https://cdn-files.apstatic.com/hike/7005571_small_1554311760.jpg";
                trail3.ImgSmallMed = "https://cdn-files.apstatic.com/hike/7005571_smallMed_1554311760.jpg";
                trail3.ImgMedium = "https://cdn-files.apstatic.com/hike/7005571_medium_1554311760.jpg";
                trail3.Length = 6.9;
                trail3.Ascent = 2219;
                trail3.Descent = -3218;
                trail3.High = 607;
                trail3.Low = 218;
                trail3.Longitude = -132.9211;
                trail3.Latitude = 46.7999;
                trail3.ConditionStatus = "Bananna peals Everywhere";
                trail3.ConditionDetails = "Slippery";
                trail3.ConditionDate = "2019-04-17 10:05:03";

                context.Add(trail1);
                context.SaveChanges();
                context.Add(trail2);
                context.SaveChanges();
                context.Add(trail3);
                context.SaveChanges();

                // Act
                var result = context.Trail.FirstOrDefault(m => m.TrailID == trail2.TrailID);

                // Assert

                Assert.Equal(result, trail2);


            };
        }

        [Fact]
        public void CanGetOneTrailFromThree_Three()
        {
            DbContextOptions<SwitchbackAPIDbContext> options = new DbContextOptionsBuilder<SwitchbackAPIDbContext>().UseInMemoryDatabase("CanCreateCourse").Options;

            using (SwitchbackAPIDbContext context = new SwitchbackAPIDbContext(options))
            {
                // Arrange
                Trail trail1 = new Trail();
                trail1.Name = "Clown Lake Trail";
                trail1.Type = "Featured Hike";
                trail1.Summary = "A great place for a picnic and watching paragliders!";
                trail1.Difficulty = "blue";
                trail1.Stars = 4.3;
                trail1.StarVotes = 50;
                trail1.Location = "Issaquah, Washington";
                trail1.Url = "https://www.hikingproject.com/trail/7005406/poo-poo-point-via-chirico-trail";
                trail1.ImgSqSmall = "https://cdn-files.apstatic.com/hike/7004771_sqsmall_1554310760.jpg";
                trail1.ImgSmall = "https://cdn-files.apstatic.com/hike/7004771_small_1554310760.jpg";
                trail1.ImgSmallMed = "https://cdn-files.apstatic.com/hike/7004771_smallMed_1554310760.jpg";
                trail1.ImgMedium = "https://cdn-files.apstatic.com/hike/7004771_medium_1554310760.jpg";
                trail1.Length = 3.9;
                trail1.Ascent = 1619;
                trail1.Descent = -1618;
                trail1.High = 1807;
                trail1.Low = 188;
                trail1.Longitude = -122.0211;
                trail1.Latitude = 47.4999;
                trail1.ConditionStatus = "All Clear";
                trail1.ConditionDetails = "Dry";
                trail1.ConditionDate = "2019-04-19 11:05:03";

                Trail trail2 = new Trail();
                trail2.Name = "Pie in the Face Trail";
                trail2.Type = "Featured Hike";
                trail2.Summary = "Watchout for Clowns throwing Pies";
                trail2.Difficulty = "Azure";
                trail2.Stars = 2.3;
                trail2.StarVotes = 20;
                trail2.Location = "Clown, Washington";
                trail2.Url = "https://www.hikingproject.com/trail/7005406/pie-face";
                trail2.ImgSqSmall = "https://cdn-files.apstatic.com/hike/7005771_sqsmall_1554310760.jpg";
                trail2.ImgSmall = "https://cdn-files.apstatic.com/hike/7005771_small_1554310760.jpg";
                trail2.ImgSmallMed = "https://cdn-files.apstatic.com/hike/7005771_smallMed_1554310760.jpg";
                trail2.ImgMedium = "https://cdn-files.apstatic.com/hike/7005771_medium_1554310760.jpg";
                trail2.Length = 2.9;
                trail2.Ascent = 1719;
                trail2.Descent = -1218;
                trail2.High = 107;
                trail2.Low = 18;
                trail2.Longitude = -132.0211;
                trail2.Latitude = 47.7999;
                trail2.ConditionStatus = "Pies Everywhere";
                trail2.ConditionDetails = "Slippery";
                trail2.ConditionDate = "2019-04-19 10:05:03";

                Trail trail3 = new Trail();
                trail3.Name = "The Slippery Bannana Trail";
                trail3.Type = "Featured Hike";
                trail3.Summary = "Watch your step, there is bannana peals every where";
                trail3.Difficulty = "Red";
                trail3.Stars = 1.3;
                trail3.StarVotes = 25;
                trail3.Location = "Bananna, Washington";
                trail3.Url = "https://www.hikingproject.com/trail/7005306/slippery-bananna";
                trail3.ImgSqSmall = "https://cdn-files.apstatic.com/hike/7005571_sqsmall_1554311760.jpg";
                trail3.ImgSmall = "https://cdn-files.apstatic.com/hike/7005571_small_1554311760.jpg";
                trail3.ImgSmallMed = "https://cdn-files.apstatic.com/hike/7005571_smallMed_1554311760.jpg";
                trail3.ImgMedium = "https://cdn-files.apstatic.com/hike/7005571_medium_1554311760.jpg";
                trail3.Length = 6.9;
                trail3.Ascent = 2219;
                trail3.Descent = -3218;
                trail3.High = 607;
                trail3.Low = 218;
                trail3.Longitude = -132.9211;
                trail3.Latitude = 46.7999;
                trail3.ConditionStatus = "Bananna peals Everywhere";
                trail3.ConditionDetails = "Slippery";
                trail3.ConditionDate = "2019-04-17 10:05:03";

                context.Add(trail1);
                context.SaveChanges();
                context.Add(trail2);
                context.SaveChanges();
                context.Add(trail3);
                context.SaveChanges();

                // Act
                var result = context.Trail.FirstOrDefault(m => m.TrailID == trail3.TrailID);

                // Assert

                Assert.Equal(result, trail3);


            };
        }

        [Fact]
        public void CanGetOneUserRatingFromOne()
        {
            DbContextOptions<SwitchbackAPIDbContext> options = new DbContextOptionsBuilder<SwitchbackAPIDbContext>().UseInMemoryDatabase("CanCreateCourse").Options;

            using (SwitchbackAPIDbContext context = new SwitchbackAPIDbContext(options))
            {
                // Arrange
                UserRatings rating1 = new UserRatings();
                rating1.ID = 1;
                rating1.TrailInfoID = 1;
                rating1.Rating = 4;


                context.Add(rating1);
                context.SaveChanges();

                // Act
                var result = context.UserRatings.FirstOrDefault(m => m.ID == rating1.ID);

                // Assert

                Assert.Equal(result, rating1);


            };
        }

        [Fact]
        public void CanGetOneUserRatingFromThree_Begining()
        {
            DbContextOptions<SwitchbackAPIDbContext> options = new DbContextOptionsBuilder<SwitchbackAPIDbContext>().UseInMemoryDatabase("CanCreateCourse").Options;

            using (SwitchbackAPIDbContext context = new SwitchbackAPIDbContext(options))
            {
                // Arrange
                UserRatings rating2 = new UserRatings();
                rating2.ID = 2;
                rating2.TrailInfoID = 2;
                rating2.Rating = 4;
                UserRatings rating3 = new UserRatings();
                rating3.ID = 3;
                rating3.TrailInfoID = 2;
                rating3.Rating = 3;
                UserRatings rating4 = new UserRatings();
                rating4.ID = 4;
                rating4.TrailInfoID = 2;
                rating4.Rating = 2;

                context.Add(rating2);
                context.Add(rating3);
                context.Add(rating4);
                context.SaveChanges();

                // Act
                var result = context.UserRatings.FirstOrDefault(m => m.ID == rating2.ID);

                // Assert

                Assert.Equal(result, rating2);


            };
        }

        [Fact]
        public void CanGetOneUserRatingFromThree_Middle()
        {
            DbContextOptions<SwitchbackAPIDbContext> options = new DbContextOptionsBuilder<SwitchbackAPIDbContext>().UseInMemoryDatabase("CanCreateCourse").Options;

            using (SwitchbackAPIDbContext context = new SwitchbackAPIDbContext(options))
            {
                // Arrange
                UserRatings rating5 = new UserRatings();
                rating5.ID = 5;
                rating5.TrailInfoID = 1;
                rating5.Rating = 4;
                UserRatings rating6 = new UserRatings();
                rating6.ID = 6;
                rating6.TrailInfoID = 1;
                rating6.Rating = 3;
                UserRatings rating7 = new UserRatings();
                rating7.ID = 7;
                rating7.TrailInfoID = 1;
                rating7.Rating = 2;

                context.Add(rating5);
                context.Add(rating6);
                context.Add(rating7);
                context.SaveChanges();

                // Act
                var result = context.UserRatings.FirstOrDefault(m => m.ID == rating6.ID);

                // Assert

                Assert.Equal(result, rating6);


            };
        }

        [Fact]
        public void CanGetOneUserRatingFromThree_End()
        {
            DbContextOptions<SwitchbackAPIDbContext> options = new DbContextOptionsBuilder<SwitchbackAPIDbContext>().UseInMemoryDatabase("CanCreateCourse").Options;

            using (SwitchbackAPIDbContext context = new SwitchbackAPIDbContext(options))
            {
                // Arrange
                UserRatings rating8 = new UserRatings();
                rating8.ID = 8;
                rating8.TrailInfoID = 3;
                rating8.Rating = 4;
                UserRatings rating9 = new UserRatings();
                rating9.ID = 9;
                rating9.TrailInfoID = 3;
                rating9.Rating = 3;
                UserRatings rating10 = new UserRatings();
                rating10.ID = 10;
                rating10.TrailInfoID = 3;
                rating10.Rating = 2;

                context.Add(rating8);
                context.Add(rating9);
                context.Add(rating10);
                context.SaveChanges();

                // Act
                var result = context.UserRatings.FirstOrDefault(m => m.ID == rating10.ID);

                // Assert

                Assert.Equal(result, rating10);


            };
        }

        [Fact]
        public void CanGetUpdateTrail()
        {
            DbContextOptions<SwitchbackAPIDbContext> options = new DbContextOptionsBuilder<SwitchbackAPIDbContext>().UseInMemoryDatabase("CanCreateCourse").Options;

            using (SwitchbackAPIDbContext context = new SwitchbackAPIDbContext(options))
            {
                // Arrange
                Trail trail1 = new Trail();
                trail1.Name = "Clown Lake Trail";
                trail1.Type = "Featured Hike";
                trail1.Summary = "A great place for a picnic and watching paragliders!";
                trail1.Difficulty = "blue";
                trail1.Stars = 4.3;
                trail1.StarVotes = 50;
                trail1.Location = "Issaquah, Washington";
                trail1.Url = "https://www.hikingproject.com/trail/7005406/poo-poo-point-via-chirico-trail";
                trail1.ImgSqSmall = "https://cdn-files.apstatic.com/hike/7004771_sqsmall_1554310760.jpg";
                trail1.ImgSmall = "https://cdn-files.apstatic.com/hike/7004771_small_1554310760.jpg";
                trail1.ImgSmallMed = "https://cdn-files.apstatic.com/hike/7004771_smallMed_1554310760.jpg";
                trail1.ImgMedium = "https://cdn-files.apstatic.com/hike/7004771_medium_1554310760.jpg";
                trail1.Length = 3.9;
                trail1.Ascent = 1619;
                trail1.Descent = -1618;
                trail1.High = 1807;
                trail1.Low = 188;
                trail1.Longitude = -122.0211;
                trail1.Latitude = 47.4999;
                trail1.ConditionStatus = "All Clear";
                trail1.ConditionDetails = "Dry";
                trail1.ConditionDate = "2019-04-19 11:05:03";

                context.Add(trail1);
                context.SaveChanges();

                trail1.ConditionStatus = "Raining Cats and Dogs";
                context.Update(trail1);
                context.SaveChanges();

                // Act
                var result = context.Trail.FirstOrDefault(m => m.TrailID == trail1.TrailID);

                // Assert

                Assert.Equal(result, trail1);


            };
        }

        [Fact]
        public void CanUpdateUserRating()
        {
            DbContextOptions<SwitchbackAPIDbContext> options = new DbContextOptionsBuilder<SwitchbackAPIDbContext>().UseInMemoryDatabase("CanCreateCourse").Options;

            using (SwitchbackAPIDbContext context = new SwitchbackAPIDbContext(options))
            {
                // Arrange
                UserRatings rating11 = new UserRatings();
                rating11.ID = 11;
                rating11.TrailInfoID = 1;
                rating11.Rating = 4;


                context.Add(rating11);
                context.SaveChanges();

                rating11.Rating = 5;
                context.Update(rating11);
                context.SaveChanges();

                // Act
                var result = context.UserRatings.FirstOrDefault(m => m.ID == rating11.ID);

                // Assert

                Assert.Equal(result, rating11);


            };
        }

    }
}
