using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Command;
using CQRS.Abstraction;
using Model;

namespace Client.Query
{
    public class ListDocumentsQueryHandler:IQueryHandler<ListDocumentsQuery,List<Document>>
    {
        private FakeContext context;

        public ListDocumentsQueryHandler(FakeContext context)
        {
            this.context = context;
        }


        public List<Document> Execute(ListDocumentsQuery query)
        {
            return context.Documents;
        }
    }
}
