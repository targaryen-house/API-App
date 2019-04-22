using Microsoft.EntityFrameworkCore;
using API_SwitchBack.Data;
using API_SwitchBack.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.Linq;

namespace API_SwitchBack.Models.Services
{
    public class UserRatingsService : IUserRatings
    {
        private SwitchbackAPIDbContext _context;

        /// <summary>
        /// Connects Service to Database
        /// </summary>
        /// <param name="context">Database</param>
        public UserRatingsService(SwitchbackAPIDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// (Create) Adds and assigns User Rating to a Trail ID
        /// </summary>
        /// <param name="userRatings">UserRating</param>
        /// <returns></returns>
        public async Task AddRating(UserRatings userRatings)
        {
            _context.UserRatings.Add(userRatings);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// (Read) Lists all the User Ratings
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserRatings> GetAll()
        {
            return _context.UserRatings;
        }

        /// <summary>
        /// (Read) Lists a User Rating by ID
        /// </summary>
        /// <param name="id">User Rating ID</param>
        /// <returns></returns>
        public UserRatings GetByID(int id)
        {
            UserRatings userRating = _context.UserRatings.Find(id);
            return userRating;
        }

        /// <summary>
        /// (Update) Edits the User Rating of the Trail
        /// </summary>
        /// <param name="id">User Rating ID</param>
        /// <param name="userRatings">User Rating row</param>
        /// <returns></returns>
        public async Task EditRating(int id, UserRatings userRatings)
        {
            UserRatings userRating = GetByID(id);
            userRating.ID = userRatings.ID;
            userRating.TrailInfoID = userRatings.TrailInfoID;
            userRating.Rating = userRatings.Rating;

            _context.UserRatings.Update(userRating);
            await _context.SaveChangesAsync();
        }
        
        /// <summary>
        /// (Delete) Removes the User Rating from the Trail
        /// </summary>
        /// <param name="id">Rating ID</param>
        /// <returns></returns>
        public async Task RemoveRating(int id)
        {
            var userRating = GetByID(id);
            _context.UserRatings.Remove(userRating);
            await _context.SaveChangesAsync();
        }
    }
}
