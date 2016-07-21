using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Abstraction;

namespace CQRS.Abstraction
{
    public class CommandExecutor
    {
        public List<ICommandHandler> Commands = new List<ICommandHandler>();

        public void Execute(ICommandHandler handler)
        {
            Commands.Add(handler);
            handler.Execute();
        }
    }
}
