using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Abstraction;

namespace Client.Command
{
    public class DocumentCreateCommand:ICommand
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}
