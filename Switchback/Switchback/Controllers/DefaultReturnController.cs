using Microsoft.AspNetCore.Mvc;
using Switchback.Models;
using Switchback.Models.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System;
using Microsoft.AspNetCore.Http;


namespace Switchback.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultReturnController : ControllerBase
    {
    
        // GET: api/DefaultReturn/5
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello world";
        }
    }
}
