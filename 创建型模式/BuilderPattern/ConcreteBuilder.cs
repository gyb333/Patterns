using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BuilderPattern
{
    public class ConcreteBuilder:Builder
    {
        private Product product = new Product();

        public override Product getProduct()
        {
            return product;
        }

        public override void setProduct(string name, string type)
        {
            product.Name = name;
            product.Type = type;
        }
    }
}
