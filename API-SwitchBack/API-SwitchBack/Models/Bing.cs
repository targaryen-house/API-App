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
        public int  ID { get; set; }
        public string LocationName { get; set; }
        public string URL { get; set; }
    }
}
