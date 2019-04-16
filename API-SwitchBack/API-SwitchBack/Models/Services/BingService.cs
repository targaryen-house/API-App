﻿using API_SwitchBack.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using Microsoft.AspNetCore.SignalR.Protocol;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace API_SwitchBack.Models.Services
{
    public class BingService : IBingManager
    {
        public void CreateBingSearch(string url)
        {
            WebRequest requestData = WebRequest.Create(url);
            requestData.Method = "GET";
            HttpWebResponse responseObj = null;
            responseObj =  (HttpWebResponse)requestData.GetResponse();

            string tempString = null;
            using(Stream stream = responseObj.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                tempString = sr.ReadToEnd();
                sr.Close();
            }

        }
    }
}
