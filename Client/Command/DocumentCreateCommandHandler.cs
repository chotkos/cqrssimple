using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Abstraction;
using Model;

namespace Client.Command
{
    public class DocumentCreateCommandHandler : ICommandHandler<DocumentCreateCommand>
    {
        private FakeContext context;

        public DocumentCreateCommandHandler(FakeContext context)
        {
            this.context = context;
        }

        public void Execute(DocumentCreateCommand command)
        {
            context.Documents.Add(new Document()
            {
                DateTime = command.Date,
                Status = DocumentStatus.Draft,
                Id = context.Documents.Max(x=>x.Id)+1,
                Name = command.Name
            });
            context.SaveChanges();
        }
    }
}
