using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.PrototypePattern
{
    public class ShallowPrototype:Prototype
    {
        public ShallowPrototype(string id):base(id)
        {

        }

        public override Prototype Clone()
        {
            return this.MemberwiseClone() as Prototype;
        }
    }
}
