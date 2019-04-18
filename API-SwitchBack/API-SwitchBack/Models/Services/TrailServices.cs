using Microsoft.EntityFrameworkCore;
using API_SwitchBack.Data;
using API_SwitchBack.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.Linq;
using System.Collections.Immutable;

namespace API_SwitchBack.Models.Service
{
    public class TrailServices : ITrail
    {
        private SwitchbackAPIDbContext _context;
        //private Rootobject.trails _getTrail;

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
        public async Task Create(Rootobject rObject)
        {
            /*var get = rObject.trails;
            var trail = await _context.Trail.ToListAsync();
           
            foreach (var value in rObject.trails)
            {
                foreach (var item in trail)
                {
                    if (item.ApiID != value.ID)
                        await AddTrail(value);
                }
    

            }*/
            foreach (var value in rObject.trails)
            {
                await AddTrail(value);
            }
        }

        private async Task AddTrail(GetTrails value)
        {
            Trail trail = new Trail();
            trail.ApiID = value.ID;
            trail.Name = value.Name;
            trail.Type = value.Type;
            trail.Summary = value.Summary;
            trail.Difficulty = value.Difficulty;
            trail.Stars = value.Stars;
            trail.StarVotes = value.StarVotes;
            trail.Location = value.Location;
            trail.Url = value.Url;
            trail.ImgSqSmall = value.ImgSqSmall;
            trail.ImgSmall = value.ImgSmall;
            trail.ImgSmallMed = value.ImgSmallMed;
            trail.ImgMedium = value.ImgMedium;
            trail.Length = value.Length;
            trail.Ascent = value.Ascent;
            trail.Descent = value.Descent;
            trail.High = value.High;
            trail.Low = value.Low;
            trail.Longitude = value.Longitude;
            trail.Latitude = value.Latitude;
            trail.ConditionStatus = value.ConditionStatus;
            trail.ConditionDetails = value.ConditionDetails;
            trail.ConditionDate = value.ConditionDate;

            _context.Trail.Add(trail);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// (Create) Adds a Trail to the database
        /// </summary>
        /// <param name="trailInfo">TrailInfo row</param>
        /// <returns></returns>
        public async Task AddTrail(Trail trail)
        {
          
                _context.Trail.Add(trail);
                await _context.SaveChangesAsync();

            
        }

        /// <summary>
        /// (Read) Gets all the Trail rows
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Trail>> GetAll(string query)
        {
            var output = await _context.Trail.ToListAsync();
            var output2 = from t in output
                         where (t.Location.Contains(query))
                         select t;
            return output2;
                
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
            trail.ApiID = id;
            trail.Name = trail.Name;
            trail.Type = trail.Type;
            trail.Summary = trail.Summary;
            trail.Difficulty = trail.Difficulty;
            trail.Stars = trail.Stars;
            trail.StarVotes = trailInfo.StarVotes;
            trail.Location = trail.Location;
            trail.Url = trail.Url;
            trail.ImgSqSmall = trail.ImgSqSmall;
            trail.ImgSmall = trail.ImgSmall;
            trail.ImgSmallMed = trail.ImgSmallMed;
            trail.ImgMedium = trail.ImgMedium;
            trail.Length = trail.Length;
            trail.Ascent = trail.Ascent;
            trail.Descent = trail.Descent;
            trail.High = trail.High;
            trail.Low = trail.Low;
            trail.Longitude = trail.Longitude;
            trail.Latitude = trail.Latitude;
            trail.ConditionStatus = trail.ConditionStatus;
            trail.ConditionDetails = trail.ConditionDetails;
            trail.ConditionDate = trail.ConditionDate;

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
