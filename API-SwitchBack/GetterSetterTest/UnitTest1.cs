using API_SwitchBack.Models;
using NuGet.Frameworks;
using System;
using Xunit;
using Xunit.Sdk;
using static API_SwitchBack.Models.Bing;

namespace GetterSetterTest
{
    public class UnitTest1
    {
        [Fact]
        public void PropertyTestTrailID()
        {
            Trail trail = new Trail
            {
                TrailID = 4
            };
            int expectedOutut = 4;
            Assert.Equal(expectedOutut, trail.TrailID);
        }
        [Fact]
        public void PropertyTestTrailApiId()
        {
            Trail trail = new Trail
            {
                ApiID = 77564
            };
            int expectedOutput = 77564;
            Assert.Equal(expectedOutput, trail.ApiID);
        }
        [Fact]
        public void PropertyTestTrailName()
        {
            Trail trail = new Trail
            {
                Name = "awesome trail"
            };
            string expectedOutput = "awesome trail";
            Assert.Equal(expectedOutput, trail.Name);
        }
        [Fact]
        public void PropertyTestTrailType()
        {
            Trail trail = new Trail
            {
                Type = "Cross-Country"
            };
            string expectedOutput = "Cross-Country";
            Assert.Equal(expectedOutput, trail.Type);
        }
        [Fact]
        public void PropertyTestTrailSummary()
        {
            Trail trail = new Trail
            {
                Summary  = "Was a very nice trail"
            };
            string expectedOutput = "Was a very nice trail";
            Assert.Equal(expectedOutput, trail.Summary);
        }
        [Fact]
        public void PropertyTestTrailDifficulty()
        {
            Trail trail = new Trail
            {
                Difficulty = "Red"
            };
            string expectedOutput = "Red";
            Assert.Equal(expectedOutput, trail.Difficulty);
        }
        [Fact]
        public void PropertyTestTrailStars()
        {
            Trail trail = new Trail
            {
                Stars = 10
            };
            int expectedOutput = 10;
            Assert.Equal(expectedOutput, trail.Stars);
        }
        [Fact]
        public void PropertyTestTrailStarVotes()
        {
            Trail trail = new Trail
            {
                StarVotes = 40
            };
            int expectedOutput = 40;
            Assert.Equal(expectedOutput, trail.StarVotes);
        }
        [Fact]
        public void PropertyTestTrailLocation()
        {
            Trail trail = new Trail
            {
                Location = "Seattle"
            };
            string expectedOutput ="Seattle";
            Assert.Equal(expectedOutput, trail.Location);
        }
        [Fact]
        public void PropertyTestTrailUrl()
        {
            Trail trail = new Trail
            {
                Url = "mock.UrL"
            };
            string expectedOutput = "mock.UrL";
            Assert.Equal(expectedOutput, trail.Url);
        }
        [Fact]
        public void PropertyTestTrailImgSqlSmall()
        {
            Trail trail = new Trail
            {
                ImgSqSmall = "Img.JPG"
            };
            string expectedOutput = "Img.JPG";
            Assert.Equal(expectedOutput, trail.ImgSqSmall);
        }
        [Fact]
        public void PropertyTestTrailImgSmall()
        {
            Trail trail = new Trail
            {
                ImgSmall = "Img2.JPG"
            };
            string expectedOutput = "Img2.JPG";
            Assert.Equal(expectedOutput, trail.ImgSmall);
        }
        [Fact]
        public void PropertyTestTrailImgMedium()
        {
            Trail trail = new Trail
            {
                ImgMedium = "Img4.JPG"
            };
            string expectedOutput = "Img4.JPG";
            Assert.Equal(expectedOutput, trail.ImgMedium);
        }
        [Fact]
        public void PropertyTestTrailImgSmallMed()
        {
            Trail trail = new Trail
            {
                ImgSmallMed = "Img3.JPG"
            };
            string expectedOutput = "Img3.JPG";
            Assert.Equal(expectedOutput, trail.ImgSmallMed);
        }
        [Fact]
        public void PropertyTestTrailLength()
        {
            Trail trail = new Trail
            {
                Length = 500
            };
            double expectedOutput = 500;
            Assert.Equal(expectedOutput, trail.Length);
        }
        [Fact]
        public void PropertyTestTrailAscent()
        {
            Trail trail = new Trail
            {
                Ascent = 1500
            };
            double expectedOutput = 1500;
            Assert.Equal(expectedOutput, trail.Ascent);
        }
        [Fact]
        public void PropertyTestTrailDescent()
        {
            Trail trail = new Trail
            {
                Descent = 2500
            };
            double expectedOutput = 2500;
            Assert.Equal(expectedOutput, trail.Descent);
        }
        [Fact]
        public void PropertyTestTrailHigh()
        {
            Trail trail = new Trail
            {
                High = 6500
            };
            double expectedOutput = 6500;
            Assert.Equal(expectedOutput, trail.High);
        }
        [Fact]
        public void PropertyTestTrailLow()
        {
            Trail trail = new Trail
            {
                Low = -6500
            };
            double expectedOutput = -6500;
            Assert.Equal(expectedOutput, trail.Low);
        }
        [Fact]
        public void PropertyTestTrailLong()
        {
            Trail trail = new Trail
            {
                Longitude = -65.0000
            };
            double expectedOutput = -65.0000;
            Assert.Equal(expectedOutput, trail.Longitude);
        }
        [Fact]
        public void PropertyTestTrailLat()
        {
            Trail trail = new Trail
            {
                Latitude = 75.0000
            };
            double expectedOutput = 75.0000;
            Assert.Equal(expectedOutput, trail.Latitude);
        }
        [Fact]
        public void PropertyTestTrailConditionStatus()
        {
            Trail trail = new Trail
            {
                ConditionStatus = "good condition tree fallen needs some work"
            };
            string expectedOutput = "good condition tree fallen needs some work";
            Assert.Equal(expectedOutput, trail.ConditionStatus);
        }
        [Fact]
        public void PropertyTestTrailConditionDetails()
        {
            Trail trail = new Trail
            {
                ConditionDetails = "Kinda rocky bring some thick boots or your feet will be sore"
            };
            string expectedOutput = "Kinda rocky bring some thick boots or your feet will be sore";
            Assert.Equal(expectedOutput, trail.ConditionDetails);
        }
        [Fact]
        public void PropertyTestTrailConditionDate()
        {
            Trail trail = new Trail
            {
                ConditionDate = "4/17/2020"
            };
            string expectedOutput = "4/17/2020";
            Assert.Equal(expectedOutput, trail.ConditionDate);
        }
        [Fact]
        public void PropertyTestBingID()
        {
            Bing bing = new Bing
            {
                ID = 1
            };
            int expectedOutput = 1;
            Assert.Equal(expectedOutput, bing.ID);


        }
        [Fact]
        public void PropertyTestBingLocationName()
        {
            Bing bing = new Bing
            {
                LocationName    =  "Seattle"
            };
            string expectedOutput= "Seattle";
            Assert.Equal(expectedOutput, bing.LocationName);


        }
        [Fact]
        public void PropertyTestBingURL()
        {
            Bing bing = new Bing
            {
                URL = "Seattle.website"
            };
            string expectedOutput = "Seattle.website";
            Assert.Equal(expectedOutput, bing.URL);


        }
  



    }
}
