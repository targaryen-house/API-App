using Microsoft.EntityFrameworkCore;
using Switchback.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Switchback.Data
{
    public class SwitchbackAPIDbContext : DbContext
    {
        //public DbSet<TrailInfo> TrailInfo { get; set; }
        public DbSet<UserRating> UserRating { get; set; }
        public DbSet<DefaultReturn> DefaultReturns { get; set; }

        public SwitchbackAPIDbContext(DbContextOptions<SwitchbackAPIDbContext> options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DefaultReturn>().HasData(
                new DefaultReturn
                {
                    ID = 1,
                    Message = "Hello world"
                },
                new DefaultReturn
                {
                    ID = 2,
                    Message = "Hello Website"
                }
                );
            

        }
    }
}
