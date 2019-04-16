using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_SwitchBack.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using API_SwitchBack.Controllers;
using API_SwitchBack.Models;
using API_SwitchBack.Models.Interfaces;
using System.Net.Http;
using Newtonsoft.Json;
using static API_SwitchBack.Models.Bing;
using API_SwitchBack.Models.Services;

namespace API_SwitchBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BingController : Controller
    {
        private IBingManager _context;
        private readonly IConfiguration Configuration;
        public BingController(IBingManager context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        [HttpGet("api/query")]
        public async void CreateBing(string query)
        {
            
            int maxResults = 100;
            string http = "http";
            string url = $"{http}://dev.virtualearth.net/REST/v1/Locations?query={query}&maxResults={maxResults}&key={Configuration["BingAPIKEY"]}";
            _context.CreateBingSearch(url);
            using (var client = new HttpClient())
            {
                
                    client.BaseAddress = new Uri("http://dev.virtualearth.net");
                    var response = await client.GetAsync($"{http}://dev.virtualearth.net/REST/v1/Locations?query={query}&maxResults={maxResults}&key={Configuration["BingAPIKEY"]}");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    BingRootobject rawData = JsonConvert.DeserializeObject<BingRootobject>(stringResult);
                    var coords1 = rawData.resourceSets[0].resources[0].point.coordinates;
                    var coords2 = rawData.resourceSets[1].resources[1].point.coordinates;
                    GetTrailsService service = new GetTrailsService();
                    service.CreateTrailsSearch(coords1[0], coords2[0]);



            }

        } 
    }
}