using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Abstraction;
using Model;

namespace Client.Command
{
    public class DocumentCreateCommandHandler : ICommandHandler
    {
        private DocumentCreateCommand command;
        private FakeContext context;

        public DocumentCreateCommandHandler(FakeContext context, DocumentCreateCommand command)
        {
            this.context = context;
            this.command = command;
        }

        public void Execute()
        {
            context.Documents.Add(new Document()
            {
                DateTime = command.Date,
                Status = DocumentStatus.Draft,
                Id = context.Documents.Count+1,
                Name = command.Name
            });
            context.SaveChanges();
        }
    }
}
