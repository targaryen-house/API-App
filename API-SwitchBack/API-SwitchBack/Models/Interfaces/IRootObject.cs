using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SwitchBack.Models.Interfaces
{
    public interface IRootObject
    {
        IEnumerator<Rootobject> GetEnumerator();

        
    }
}

// https://stackoverflow.com/questions/15159014/c-sharp-foreach-statement-does-not-contain-public-definition-for-getenumerator
