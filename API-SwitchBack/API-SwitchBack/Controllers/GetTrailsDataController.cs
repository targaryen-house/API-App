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
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System.Collections;
using System.Threading;
using System.Runtime.ConstrainedExecution;

namespace API_SwitchBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetTrailsDataController : ControllerBase
    {
        /// <summary>
        /// specifies which db
        /// </summary>
        private SwitchbackAPIDbContext _context;
        /// <summary>
        /// specifies configurations
        /// </summary>
        private readonly IConfiguration Configuration;
        /// <summary>
        /// pass in database and configuration settings
        /// </summary>
        /// <param name="context">data</param>
        /// <param name="configuration">connection strings, api, ect...</param>
        public GetTrailsDataController(SwitchbackAPIDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

    }
}