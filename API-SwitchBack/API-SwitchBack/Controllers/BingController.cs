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
        private IGetTrails _getTrails;
        private ITrail _trail;
        private readonly IConfiguration Configuration;
        public BingController(IBingManager context, IConfiguration configuration, IGetTrails trailContext, ITrail trail)
        {
            _context = context;
            Configuration = configuration;
            _getTrails = trailContext;
            _trail = trail;
        }


        [HttpGet]
        public async Task<IEnumerable<Trail>> Get(string query)
        {
            
            int maxResults = 100;
            string http = "http";
            string url = $"{http}://dev.virtualearth.net/REST/v1/Locations?query={query}&maxResults={maxResults}&key={Configuration["BingAPIKEY"]}";
            _context.CreateBingSearch(url);
            using (var client = new HttpClient( ))
            {
                
                    client.BaseAddress = new Uri("http://dev.virtualearth.net");
                    var response = await client.GetAsync($"http://dev.virtualearth.net/REST/v1/Locations?query={query}&maxResults={maxResults}&key={Configuration["BINGAPIKEY"]}");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    BingRootobject rawData = JsonConvert.DeserializeObject<BingRootobject>(stringResult);
                    var coords1 = rawData.resourceSets[0].resources[0].point.coordinates[0];
                    var coords2 = rawData.resourceSets[0].resources[0].point.coordinates[1];
                    var rObject = _getTrails.CreateTrailsSearch(coords1, coords2);

                // add rObject to db
                 _trail.Create(rObject);
                var trailk = _trail.GetAll();
                /*var output = from t in trailk
                             where (t.Location.Contains(query))
                             select t;
                             */

                //query db
                //send query results back to user
                //return output;

                return null;
                //call iTralData to make a create to add to db
                
            }

        } 
    }
}