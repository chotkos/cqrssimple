using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Abstraction;
using Model;

namespace Client.Command
{
    public class DocumentRemoveCommandHandler : ICommandHandler
    {
        private DocumentRemoveCommand command;
        private FakeContext context;

        public DocumentRemoveCommandHandler(FakeContext context, DocumentRemoveCommand command)
        {
            this.context = context;
            this.command = command;
        }

        public void Execute()
        {
            context.Documents.Remove(context.Documents.Single(x => x.Id == command.Id));
            context.SaveChanges();
        }
    }
}
