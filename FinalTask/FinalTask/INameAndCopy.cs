﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    interface INameAndCopy
    {
        string Name { get; set;}
        virtual object DeepCopy(); 
    }
}
