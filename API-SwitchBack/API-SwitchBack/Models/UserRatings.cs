using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SwitchBack.Models
{
    public class UserRatings
    {
        public int ID { get; set; }
        public int TrailInfoID { get; set; }
        public int Rating { get; set; }

        public Trail Trail { get; set; }
    }
}
