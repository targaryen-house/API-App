using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SwitchBack.Data
{
    public class SwitchbackAPIDbContext : DbContext
    {
        public DbSet<SwitchbackAPIDbContext> APIController { get; set; }
        //public DbSet<TrailInfo> TrailInfos { get; set; }
        //public DbSet<UserRating> UserRatings { get; set; }

        public SwitchbackAPIDbContext(DbContextOptions<SwitchbackAPIDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        

    }
}
