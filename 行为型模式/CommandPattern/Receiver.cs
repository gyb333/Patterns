﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CommandPattern
{
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("执行请求");
        }
    }
}
