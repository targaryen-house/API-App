using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Transactions;

namespace API_SwitchBack.Models
{
    public class GetTrails
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string summary { get; set; }
        public string difficulty { get; set; }
        public float stars { get; set; }
        public int starVotes { get; set; }
        public string location { get; set; }
        public string url { get; set; }
        public string imgSqSmall { get; set; }
        public string imgSmall { get; set; }
        public string imgSmallMed { get; set; }
        public string imgMedium { get; set; }
        public float length { get; set; }
        public int ascent { get; set; }
        public int descent { get; set; }
        public int high { get; set; }
        public int low { get; set; }
        public float longitude { get; set; }
        public float latitude { get; set; }
        public string conditionStatus { get; set; }
        public string conditionDetails { get; set; }
        public string conditionDate { get; set; }


    }
}
