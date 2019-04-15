using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SwitchBack.Data
{
    public class SwitchbackAPIDbContext 
    {


        public DbSet<SwitchbackAPIDbContext> APIController { get; set; }

    }
}
