using System.IO;
using System.Net;
using Microsoft.EntityFrameworkCore;
using API_SwitchBack.Data;
using API_SwitchBack.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.Linq;
using Newtonsoft.Json;

namespace API_SwitchBack.Models.Services
{
    public class GetTrailsService : IGetTrails

    {
        public Rootobject CreateTrailsSearch(float latitude,float longitude)
        {
            string url = $"https://www.hikingproject.com/data/get-trails?lat={latitude}&lon={longitude}&maxDistance=10&key=200422226-db1edfb53bd53e0ee7842110ac51bbee";
            WebRequest requestData = WebRequest.Create(url);
            requestData.Method = "GET";
            HttpWebResponse responseObj = null;
            responseObj = (HttpWebResponse)requestData.GetResponse();

            string tempString = null;
            using (Stream stream = responseObj.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                tempString = sr.ReadToEnd();
                sr.Close();
            }
            Rootobject rawData = JsonConvert.DeserializeObject<Rootobject>(tempString);
            return rawData;



        }
    }
}
