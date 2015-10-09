using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FlyweightPattern
{
    public abstract class Flyweight
    {
        public abstract void Operation(int extrinsicstate);
    }
}
