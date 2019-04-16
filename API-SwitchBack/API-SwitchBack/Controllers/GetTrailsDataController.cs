﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_SwitchBack.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using API_SwitchBack.Controllers;
using API_SwitchBack.Models;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;

namespace API_SwitchBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetTrailsDataController : ControllerBase
    {
        private SwitchbackAPIDbContext _context;
        private readonly IConfiguration Configuration;
        public GetTrailsDataController(SwitchbackAPIDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        [HttpGet]
        public async Task<IActionResult> Create(float longitude, float latitude)
        {
            // https://www.hikingproject.com/data/get-trails?lat=47.4989852&lon=-122.0082429&maxDistance=10&key=200422226-db1edfb53bd53e0ee7842110ac51bbee
            //string http = "https://www.hikingproject.com/data";
            //string url = $"{http}/data/get-trails?lat={latitude}&lon={longitude}&maxDistance=10&key=200422226-db1edfb53bd53e0ee7842110ac51bbee";
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://www.hikingproject.com");
                var response = await client.GetAsync($"https://www.hikingproject.com/data/get-trails?lat=47.6062&lon=-122.3321&maxDistance=10&key=200422226-db1edfb53bd53e0ee7842110ac51bbee");
                response.EnsureSuccessStatusCode();

                var stringResult = await response.Content.ReadAsStringAsync();
                Rootobject rawData = JsonConvert.DeserializeObject<Rootobject>(stringResult);
                foreach (var value in rawData.trails)
                {
                    _context.Add(
                    new Trail
                    {
                        ID = value.ID,
                        Name =  value.Name,
                        Type = value.Type,
                        Summary = value.Summary,
                        Difficulty = value.Difficulty,
                        Stars =  value.Stars,
                        StarVotes = value.StarVotes,
                        Location=  value.Location,
                        Url = value.Url,
                        ImgSqSmall = value.ImgSqSmall,
                        ImgSmall = value.ImgSmall,
                        ImgSmallMed = value.ImgSmallMed,
                        ImgMedium = value.ImgMedium,
                        Length = value.Length,
                        Ascent = value.Ascent,
                        Descent = value.Descent,
                        High = value.High,
                        Low = value.Low,
                        Longitude = value.Longitude,
                        Latitude = value.Latitude,
                        ConditionStatus = value.ConditionStatus,
                        ConditionDetails = value.ConditionDetails,
                        ConditionDate = value.ConditionDate
                    });

                }
            
                



            }

           return null;
        }
    }
}