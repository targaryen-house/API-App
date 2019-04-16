using System.Collections.Generic;
using System.Threading.Tasks;

using System;
using System.Linq;

namespace API_SwitchBack.Models.Interfaces
{
    public interface IUserRatings
    {
        IEnumerable<UserRatings> GetAll();

        UserRatings GetByID(int id);

        Task AddRating(UserRatings userRatings);

        Task EditRating(int id, UserRatings userRatings);

        Task RemoveRating(int id);
    }
}
