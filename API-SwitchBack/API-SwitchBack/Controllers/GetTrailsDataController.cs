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

namespace API_SwitchBack.Data
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
        public IActionResult Create(float longitude, float latitude)
        {
            int maxResults = 100;
            string http = "https://www.hikingproject.com/data";
            string url = $"{http}/get-trails?lat={latitude}&lon={longitude}&maxDistance=10&key=200422226-db1edfb53bd53e0ee7842110ac51bbee";
            return Rootobject;
        }

        // https://www.hikingproject.com/data/get-trails?lat=40.0274&lon=-105.2519&maxDistance=10&key=200422226-db1edfb53bd53e0ee7842110ac51bbee

    }
}