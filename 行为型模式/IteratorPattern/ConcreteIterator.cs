using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.IteratorPattern
{
    public class ConcreteIterator:Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }


        public override object First()
        {
            return aggregate[0];
        }

        public override object Next()
        {
            object result = null;
            current++;
            if (current < aggregate.Count)
            {
                result = aggregate[current];
            }
            return result;
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count ? true : false;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }
    }
}
