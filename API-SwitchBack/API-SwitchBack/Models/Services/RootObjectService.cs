using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_SwitchBack.Models.Interfaces;

namespace API_SwitchBack.Models.Services
{
    public class RootObjectService : IRootObject
    {
        private List<RootObjectService> rootObjects;


        IEnumerator<Rootobject> IRootObject.GetEnumerator()
        {
            return rootObjects.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return rootObjects.GetEnumerator();
        }

        
    }
}
