using System.IO;
using System.Net;
using Microsoft.EntityFrameworkCore;
using API_SwitchBack.Data;
using API_SwitchBack.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.Linq;

namespace API_SwitchBack.Models.Services
{
    public class GetTrailsService : IGetTrails

    {
        public void CreateTrailsSearch(string url)
        {
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
        }
    }
}
