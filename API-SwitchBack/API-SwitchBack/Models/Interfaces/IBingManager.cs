﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SwitchBack.Models.Interfaces
{
    public interface IBingManager
    {
        string CreateBingSearch(string url);
        
    }
}
