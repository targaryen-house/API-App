using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SwitchBack.Models.Interfaces
{
    interface IGetTrails
    {
        void CreateTrailsSearch(float latitude, float longitude);
    }
}
