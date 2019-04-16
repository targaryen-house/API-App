using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_SwitchBack.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using API_SwitchBack.Controllers;

namespace API_SwitchBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BingController : Controller
    {
        private SwitchbackAPIDbContext _context;
        private readonly IConfiguration Configuration;
        public BingController(SwitchbackAPIDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetSearch(string query)
        {
            int maxResults = 100;
            string http = "http";
            string url = $"{http}://dev.virtualearth.net/REST/v1/Locations?query={query}&maxResults={maxResults}&key=["BingAPIKEY"]";
        }
    }
}