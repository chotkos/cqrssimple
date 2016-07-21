using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Abstraction;
using Model;

namespace Client.Command
{
    public class DocumentRemoveCommandHandler: ICommandHandler<DocumentRemoveCommand>
    {
        private FakeContext context;

        public DocumentRemoveCommandHandler(FakeContext context)
        {
            this.context = context;
        }

        public void Execute(DocumentRemoveCommand command)
        {
            context.Documents.Remove(context.Documents.Single(x => x.Id == command.Id));
            context.SaveChanges();
        }
    }
}
