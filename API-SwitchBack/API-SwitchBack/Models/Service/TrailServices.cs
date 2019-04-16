using Microsoft.EntityFrameworkCore;
using API_SwitchBack.Data;
using API_SwitchBack.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.Linq;

namespace API_SwitchBack.Models.Service
{
    public class TrailServices : ITrail
    {
        private SwitchbackAPIDbContext _context;

        /// <summary>
        /// Connects Service to Database
        /// </summary>
        /// <param name="context">Database</param>
        public TrailServices(SwitchbackAPIDbContext context)
        {
            _context = context;
        }
        
        /// <summary>
        /// (Create) Adds a Trail to the database
        /// </summary>
        /// <param name="trailInfo">TrailInfo row</param>
        /// <returns></returns>
        public async Task AddTrail(Trail trailInfo)
        {
            _context.Trail.Add(trailInfo);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// (Read) Gets all the Trail rows
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Trail> GetAll()
        {
            return _context.Trail;
        }

        /// <summary>
        /// (Read) Gets a Trail by ID
        /// </summary>
        /// <param name="id">Trail ID</param>
        /// <returns></returns>
        public Trail GetByID(int id)
        {
            Trail trailInfo = _context.Trail.Find(id);
            return trailInfo;
        }

        /// <summary>
        /// (Update) Edits a Trail entry
        /// </summary>
        /// <param name="id">Trail ID</param>
        /// <param name="trailInfo">Trail Info row</param>
        /// <returns></returns>
        public async Task EditTrail(int id, Trail trailInfo)
        {
            Trail trail = GetByID(id);
            trail.id = id;
            trail.name = trail.name;
            trail.type = trail.type;
            trail.summary = trail.summary;
            trail.difficulty = trail.difficulty;
            trail.stars = trail.stars;
            trail.starVotes = trailInfo.starVotes;
            trail.location = trail.location;
            trail.url = trail.url;
            trail.imgSqSmall = trail.imgSqSmall;
            trail.imgSmall = trail.imgSmall;
            trail.imgSmallMed = trail.imgSmallMed;
            trail.imgMedium = trail.imgMedium;
            trail.length = trail.length;
            trail.ascent = trail.ascent;
            trail.descent = trail.descent;
            trail.high = trail.high;
            trail.low = trail.low;
            trail.longitude = trail.longitude;
            trail.latitude = trail.latitude;
            trail.conditionStatus = trail.conditionStatus;
            trail.conditionDetails = trail.conditionDetails;
            trail.conditionDate = trail.conditionDate;

            _context.Trail.Update(trail);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// (Delete) Removes a Trail Info row
        /// </summary>
        /// <param name="id">trail Info ID</param>
        /// <returns></returns>
        public async Task RemoveTrail(int id)
        {
            var trail = GetByID(id);
            _context.Trail.Remove(trail);
            await _context.SaveChangesAsync();
        }
    }
}
