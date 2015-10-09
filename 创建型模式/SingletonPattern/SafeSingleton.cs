using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SingletonPattern
{
    public sealed class SafeSingleton
    {
        private static SafeSingleton instance = null;

        private static readonly object SyncRoot = new object();

        private SafeSingleton() { }

        public static SafeSingleton Instance
        {
            get
            {
                if (null == instance)
                {
                    lock (SyncRoot)             //对象加锁 增加了额外的开销，损失了性能。
                    {
                        if (null == instance) instance = new SafeSingleton();
                    }
                }
                return instance;
            }
        }

    }
}
