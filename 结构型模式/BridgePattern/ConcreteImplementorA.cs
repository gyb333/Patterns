﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BridgePattern
{
    public class ConcreteImplementorA:Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("A");
        }
    }
}
