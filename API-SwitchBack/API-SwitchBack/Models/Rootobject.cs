using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SwitchBack.Models
{
    public class Rootobject 
    {
        
        public GetTrails[] trails { get; set; }
        public int success { get; set; }

        /*private List<Rootobject> rootobjects;

        public IEnumerator<Rootobject> GetEnumerator()
        {
            return rootobjects.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return rootobjects.GetEnumerator();
        }*/
    }
}
