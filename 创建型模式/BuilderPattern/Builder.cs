using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BuilderPattern
{
    public abstract class Builder
    {
        public abstract void setProduct(string name, string type);
        public abstract Product getProduct();
    }
}
