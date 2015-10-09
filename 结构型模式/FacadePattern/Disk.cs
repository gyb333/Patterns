using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FacadePattern
{
    public class Disk
    {
        public void Load()
        {
            Console.WriteLine("加载磁盘");
        }

        public void UnLoad()
        {
            Console.WriteLine("卸载磁盘");
        }
    }
}
