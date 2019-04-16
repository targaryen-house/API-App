using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_SwitchBack.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetTrailsDataController : ControllerBase
    {

        public class Rootobject
        {
            public Trail[] trails { get; set; }
            public int success { get; set; }
        }

        public class Trail
        {
            public int id { get; set; }
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
}