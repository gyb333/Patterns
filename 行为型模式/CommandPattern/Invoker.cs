using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CommandPattern
{
    public class Invoker
    {
        private Command command;

        public Command Command
        {
            set
            {
                command = value;
            }
        }

        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
