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
    public class UserRatingsController : ControllerBase
    {
        private readonly IUserRatings _userRatings;

        /// <summary>
        /// Brings in Database
        /// </summary>
        /// <param name="userRatings"></param>
        public UserRatingsController(IUserRatings userRatings)
        {
            _userRatings = userRatings;
        }

        /// <summary>
        /// (Get) Gets all User Rating Rows
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<UserRatings>> Get()
        {
            return _userRatings.GetAll().ToList();
        }

        /// <summary>
        /// (Get) Get User Rating by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            UserRatings userRatings = _userRatings.GetByID(id);
            if (userRatings == null)
            {
                return NotFound();
            }
            return Ok(userRatings);
        }

        /// <summary>
        /// (Post) Post User Ratings
        /// </summary>
        /// <param name="userRatings">User Rating Row</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserRatings userRatings)
        {
            if (userRatings.ID <= 0)
            {
                await _userRatings.AddRating(userRatings);
            }
            else
            {
                await Put(userRatings.ID, userRatings);
            }
            return RedirectToAction("Get", new { id = userRatings.ID });
        }

        /// <summary>
        /// (Put) Edit User Ratings
        /// </summary>
        /// <param name="id">User Rating ID</param>
        /// <param name="userRatings">User Rating row</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Put(int id, [FromBody] UserRatings userRatings)
        {
            UserRatings userRating = _userRatings.GetByID(id);
            if (userRating != null)
            {
                await _userRatings.EditRating(id, userRating);
            }
            else
            {
                await Post(userRating);
            }
            return RedirectToAction("Get", new { id = userRating.ID });
        }

        /// <summary>
        /// (Delete) Delete User Rating by ID
        /// </summary>
        /// <param name="id">User Rating ID</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _userRatings.RemoveRating(id);
            return Ok();
        }
    }
}