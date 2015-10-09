using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibilityPattern
{
    public abstract class Handler
    {
        protected Handler successor;
        public Handler Successor
        {
            set
            {
                successor = value;
            }
        }

        public abstract void HandleRequest(int request);
    }
}
