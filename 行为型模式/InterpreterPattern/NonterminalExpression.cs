﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.InterpreterPattern
{
    class NonterminalExpression:AbstractExpression
    {

        public override void Interpret(Context context)
        {
            Console.WriteLine("非终端解释器");
        }
    }
}
