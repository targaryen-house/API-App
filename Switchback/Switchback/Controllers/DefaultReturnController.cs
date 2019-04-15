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
        private readonly IDefaultReturn _context;
        public DefaultReturnController(IDefaultReturn context){
            _context = context;
        }

        // GET: api/DefaultReturn/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<DefaultReturn>> Get(int id)
        {
            DefaultReturn defaultReturn = await _context.GetDefaultReturn(id);
            if (id < 1){
                return NotFound();
            }
            return Ok(defaultReturn.Message);
        }
    }
}
