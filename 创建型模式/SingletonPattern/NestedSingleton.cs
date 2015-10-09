using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SingletonPattern
{
    public sealed class NestedSingleton
    {
        private NestedSingleton() { }

        public static NestedSingleton Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            internal static readonly NestedSingleton instance = new NestedSingleton();
        }
    }
}
