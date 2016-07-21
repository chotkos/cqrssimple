using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Abstraction;

namespace CQRS.Abstraction
{
    public class QueryExecutor
    {
        public TResult Execute<TResult>(IQueryHandler<TResult> queryHandler)
        {
            return queryHandler.Execute();
        }
    }
}
