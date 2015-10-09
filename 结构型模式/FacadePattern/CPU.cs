using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FacadePattern
{
    public class CPU
    {
        public void StartUp()
        {
            Console.WriteLine("启动CPU");
        }

        public void ShutDown()
        {
            Console.WriteLine("关闭CPU");
        }
    }
}
