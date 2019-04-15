using System.Collections.Generic;
using System.Threading.Tasks;

using System;
using System.Linq;


namespace Switchback.Models.Interface
{
    public  interface IDefaultReturn
    {
        Task<DefaultReturn> GetDefaultReturn(int id);

    }
}
