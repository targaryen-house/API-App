using Microsoft.AspNetCore.Mvc;
using API_SwitchBack.Models;
using API_SwitchBack.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System;
using Microsoft.AspNetCore.Http;


namespace API_SwitchBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrailController : ControllerBase
    {
        private readonly ITrail _trail;

        /// <summary>
        /// Pull Database
        /// </summary>
        /// <param name="trail">Trail Table</param>
        public TrailController(ITrail trail)
        {
            _trail = trail;
        }

        /// <summary>
        /// (Get) Get all Trail Rows
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name ="GetAll")]
        public async Task<IEnumerable<Trail>> GetAll(string query)
        {


            return await _trail.GetAll(query);
        }

        /// <summary>
        /// (Get) Gets a Trail by ID
        /// </summary>
        /// <param name="id">Trail ID</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Trail trail = _trail.GetByID(id);
            if (trail == null)
            {
                return NotFound();
            }
            return Ok(trail);
        }

        [HttpGet("{trailName}", Name = "GetTrail")]
        public IActionResult GetTrail(string trailName)
        {

            var trail = _trail.GetByName(trailName);


            if (trail == null)
            {
                return NotFound();
            }
            return Ok(trail);
        }


        /// <summary>
        /// (Post) Posts a Trail
        /// </summary>
        /// <param name="trail">Trail</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Trail trail)
        {
            if (trail.ApiID <= 0)
            {
                await _trail.AddTrail(trail);
            }
            else
            {
                await Put(trail.TrailID, trail);
            }
            return Ok(RedirectToAction("Get", new { id = trail.TrailID }));

        }

        /// <summary>
        /// (Put) Updates Trail data
        /// </summary>
        /// <param name="id">Trail ID</param>
        /// <param name="trail">Trail row</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Trail trail)
        {
            Trail trailInfo = _trail.GetByID(id);
            if (trailInfo != null)
            {
                await _trail.EditTrail(id, trailInfo);
            }
            else
            {
                await Post(trailInfo);
            }
            return Ok(RedirectToAction("Get", new { id = trailInfo.TrailID }));
        }

        /// <summary>
        /// (Delete) Removes a Trail row
        /// </summary>
        /// <param name="id">Trail ID</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            return Ok(_trail.RemoveTrail(id));
        }
    }
}