using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    /// <summary>
    /// 跟装饰模式比较
    /// </summary>
    public class Composite:AbstractComponet
    {
        private IList<AbstractComponet> _childern = new List<AbstractComponet>();

        public Composite()
        {

        }

        public Composite(string name):base(name)
        {

        }

        public override AbstractComponet Add(AbstractComponet componet)
        {
            _childern.Add(componet);
            return componet;
        }

        public override void Remove(AbstractComponet componet)
        {
            _childern.Remove(componet);
        }

        public override void Display(int depth)
        {
            StringBuilder sbDepth = new StringBuilder(new String('-', depth) + Name);
            Console.WriteLine(sbDepth);
            foreach (AbstractComponet child in _childern)
                child.Display(depth + 1);
        }

    }
}
