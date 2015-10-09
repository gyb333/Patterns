using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.MementoPattern
{
    public class Memento
    {
        private string state;

        public string State
        {
            get { return state; }
            private set { state = value; }
        }

        public Memento(string state)
        {
            this.state = state;
        }
    }
}
