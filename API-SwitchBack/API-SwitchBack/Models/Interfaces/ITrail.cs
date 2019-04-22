using System.Collections.Generic;
using System.Threading.Tasks;

using System;
using System.Linq;


namespace API_SwitchBack.Models.Interfaces
{
    public interface ITrail
    {
        Task<IEnumerable<Trail>> GetAll(string query);

        Task<Trail> GetByName(string query);

        Trail GetByID(int id);

        Task Create(Rootobject rObject);

        Task AddTrail(Trail trail);

        Task EditTrail(int id, Trail trailInfo);

        Task RemoveTrail(int id);
    }
}
