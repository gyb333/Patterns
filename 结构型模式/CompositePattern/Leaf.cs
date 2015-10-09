using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    public class Leaf:AbstractComponet
    {
        public Leaf()
        {

        }

        public Leaf(string name):base(name)
        {

        }

        public override void Display(int depth)
        {
            StringBuilder sbDepth = new StringBuilder(new String('-', depth) + Name);
            Console.WriteLine(sbDepth);
        }

        public override AbstractComponet Add(AbstractComponet componet)
        {
            throw new NotImplementedException();
        }

        public override void Remove(AbstractComponet componet)
        {
            throw new NotImplementedException();
        }
    }
}
