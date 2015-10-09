using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.PrototypePattern
{
    public class DeepPrototype:Prototype    
    {
        public DeepPrototype(string id):base(id)
        {

        }

        public override Prototype Clone()
        {
            DeepPrototype dp = new DeepPrototype(Id);
            return dp;
        }
    }
}
