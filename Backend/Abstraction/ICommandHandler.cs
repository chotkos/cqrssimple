using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Abstraction;

namespace CQRS.Abstraction
{
    public interface ICommandHandler<TCommand>
    {
        void Execute(TCommand command);
    }
}
