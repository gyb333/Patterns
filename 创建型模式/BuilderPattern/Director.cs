using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BuilderPattern
{
    public class Director
    {
        private Builder builder = new ConcreteBuilder();

        public Product getAProduct()
        {
             builder.setProduct("A", "A");
             return builder.getProduct();
        }

        public Product getBProduct()
        {
            builder.setProduct("B", "B");
            return builder.getProduct();
        }

    }
}
