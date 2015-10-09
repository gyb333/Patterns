using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SingletonPattern
{
    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> lazy = new Lazy<LazySingleton>(()=>new LazySingleton());

        private LazySingleton() { }

        public static LazySingleton Instance
        {
            get
            {
                return lazy.Value;
            }
        }


    }
}
