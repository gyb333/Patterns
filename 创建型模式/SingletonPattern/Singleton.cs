using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SingletonPattern
{
    public sealed class Singleton
    {
        private static Singleton instance = null;           //惰性实例化

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return instance ?? (instance = new Singleton());            //对于线程来说不是安全的
            }
        }
    }
}
