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
    public class ListDocumentsQueryHandler:IQueryHandler<List<Document>>
    {
        private ListDocumentsQuery query;
        private FakeContext context;

        public ListDocumentsQueryHandler(FakeContext context, ListDocumentsQuery query)
        {
            this.context = context;
            this.query = query;
        }
        

        List<Document> IQueryHandler<List<Document>>.Execute()
        {
            return context.Documents;
        }
    }
}
