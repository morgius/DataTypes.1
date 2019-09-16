﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Horse : Animal
    {
        public string Name { get; set; } = "Horse";

        public override int GetLegs()
        {
            return 4;
        }
    }
}
