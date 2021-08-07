﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade.Shapes
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.Write("**\n**\n");
        }
    }
}
