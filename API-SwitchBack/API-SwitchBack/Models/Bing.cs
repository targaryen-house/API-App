using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Transactions;

namespace API_SwitchBack.Models
{
    public class Bing
    {
        public Bing()
        {
            URL = "";
        }
        public Bing(string url)
        {
            URL = url;
        }
        public int ID { get; set; }
        public string LocationName { get; set; }
        public string URL { get; set; }

        public class BingRootobject
        {
            public string authenticationResultCode { get; set; }
            public string brandLogoUri { get; set; }
            public string copyright { get; set; }
            public BingResourceset[] resourceSets { get; set; }
            public int statusCode { get; set; }
            public string statusDescription { get; set; }
            public string traceId { get; set; }
        }

        public class BingResourceset
        {
            public int estimatedTotal { get; set; }
            public BingResource[] resources { get; set; }
        }

        public class BingResource
        {
            public string __type { get; set; }
            public float[] bbox { get; set; }
            public string name { get; set; }
            public BingPoint point { get; set; }
            public string confidence { get; set; }
            public string entityType { get; set; }
            public string[] matchCodes { get; set; }
        }

        public class BingPoint
        {
            public string type { get; set; }
            public float[] coordinates { get; set; }
        }


       

    }
}
