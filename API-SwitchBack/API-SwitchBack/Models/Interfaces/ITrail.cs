using System.Collections.Generic;
using System.Threading.Tasks;

using System;
using System.Linq;


namespace API_SwitchBack.Models.Interfaces
{
    public interface ITrail
    {
        IEnumerable<Trail> GetAll();

        Trail GetByID(int id);

        Task AddTrail(Trail trailInfo);

        Task EditTrail(int id, Trail trailInfo);

        Task RemoveTrail(int id);
    }
}
