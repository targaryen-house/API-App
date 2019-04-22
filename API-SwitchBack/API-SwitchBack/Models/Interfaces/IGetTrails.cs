using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SwitchBack.Models.Interfaces
{
    public interface IGetTrails
    {
        /// <summary>
        /// Trails root object for search results including the lat and lon
        /// </summary>
        /// <param name="latitude">lat from bing response</param>
        /// <param name="longitude">lon from bing response</param>
        /// <returns>root object for trails in json</returns>
        Rootobject CreateTrailsSearch(float latitude, float longitude);

        
    }
}
