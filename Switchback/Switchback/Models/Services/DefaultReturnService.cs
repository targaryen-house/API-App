using Switchback.Data;
using Switchback.Models.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

using System;
using System.Linq;


namespace Switchback.Models.Services
{
    public class DefaultReturnService : IDefaultReturn
    {
        private readonly SwitchbackAPIDbContext _context;

        public DefaultReturnService(SwitchbackAPIDbContext context)
        {
            _context = context;
        }

        public async Task<DefaultReturn> GetDefaultReturn(int id)
        {
            DefaultReturn defaultReturn = await _context.DefaultReturns.FindAsync(id);
            return defaultReturn;
        }
    }
}
