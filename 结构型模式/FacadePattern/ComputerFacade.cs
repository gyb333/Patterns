using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FacadePattern
{
    public class ComputerFacade
    {
        private CPU cpu;
        private Memory memory;
        private Disk disk;

        public ComputerFacade()
        {
            cpu = new CPU();
            memory = new Memory();
            disk = new Disk();
        }

        public void StartUp()
        {
            cpu.StartUp();
            memory.Load();
            disk.Load();
        }

        public void ShutDown()
        {
            cpu.ShutDown();
            memory.Clear();
            disk.UnLoad();
        }
    }
}
