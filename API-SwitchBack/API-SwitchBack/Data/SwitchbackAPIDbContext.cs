using Microsoft.EntityFrameworkCore;
using API_SwitchBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SwitchBack.Data
{

    public class SwitchbackAPIDbContext : DbContext
    {
        public DbSet<Trail> Trail { get; set; }
        public DbSet<UserRatings> UserRatings { get; set; }

        public SwitchbackAPIDbContext(DbContextOptions<SwitchbackAPIDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trail>().HasData(

             new Trail

             {

                 ID = 7005406,
                 Name = "Poo Poo Point via Chirico Trail",
                 Type = "Featured Hike",
                 Summary = "A great place for a picnic and watching paragliders!",
                 Difficulty = "blue",
                 Stars = 4.3,
                 StarVotes = 50,
                 Location = "Issaquah, Washington",
                 Url = "https://www.hikingproject.com/trail/7005406/poo-poo-point-via-chirico-trail",
                 ImgSqSmall = "https://cdn-files.apstatic.com/hike/7004771_sqsmall_1554310760.jpg",
                 ImgSmall = "https://cdn-files.apstatic.com/hike/7004771_small_1554310760.jpg",
                 ImgSmallMed = "https://cdn-files.apstatic.com/hike/7004771_smallMed_1554310760.jpg",
                 ImgMedium = "https://cdn-files.apstatic.com/hike/7004771_medium_1554310760.jpg",
                 Length = 3.9,
                 Ascent = 1619,
                 Descent = -1618,
                 High = 1807,
                 Low = 188,
                 Longitude = -122.0211,
                 Latitude = 47.4999,
                 ConditionStatus = "All Clear",
                 ConditionDetails = "Dry",
                 ConditionDate = "2019-03-28 11:05:03"

             });
        }
        


    }
}
