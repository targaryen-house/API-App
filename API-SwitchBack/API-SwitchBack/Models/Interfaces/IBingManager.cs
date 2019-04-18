using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SwitchBack.Models.Interfaces
{
    public interface IBingManager
    {
        /// <summary>
        /// will go to bing with the query for long and lat
        /// </summary>
        /// <param name="url">api call </param>
        /// <returns>Bing root object</returns>
        string CreateBingSearch(string url);
        
    }
}
