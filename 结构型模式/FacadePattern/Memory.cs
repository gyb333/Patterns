using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FacadePattern
{
    public class Memory
    {
        public void Load()
        {
            Console.WriteLine("加载内存");
        }

        public void Clear()
        {
            Console.WriteLine("清空内存");
        }

    }
}
