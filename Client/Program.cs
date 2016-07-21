using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using CQRS.Abstraction;
using Client.Command;
using Client.Query;
using Model;

namespace Client
{

    class Program
    {
        private static CommandExecutor ce = new CommandExecutor();
        private static QueryExecutor qe = new QueryExecutor();
        private static FakeContext fc = new FakeContext();
        static void Main(string[] args)
        {
            var run = true;
            while (run)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Select what you want to do:\n1\tCreate Document\n2\tRemove Document\n3\tList Documents\nexit\tTo exit");
                var resp = Console.ReadLine();
                Console.WriteLine("---------------------------");
                switch (resp)
                {
                    case "1":
                        CreateDocument();
                        break;
                    case "2":
                        RemoveDocument();
                        break;
                    case "3":
                        ListDocuments();
                        break;
                    case "exit":
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Wrong number.");
                        break;
                }
            }
        }

        private static void ListDocuments()
        {
            var q = new ListDocumentsQuery();
            var handler = new ListDocumentsQueryHandler(fc,q);

            var res = qe.Execute(handler);
            foreach (var item in res)
            {
                Console.WriteLine(String.Format("{0}\t{1}\t{2}\t{3}",item.Id,item.Name,item.DateTime,item.Status));
            }
        }
    

        private static void CreateDocument()
        {
            Console.WriteLine("Write name:");

            var com = new DocumentCreateCommand()
            {
                Name = Console.ReadLine(),
                Date = DateTime.Now,
            };

            var handler = new DocumentCreateCommandHandler(fc, com);

            ce.Execute(handler);
        }

        private static void RemoveDocument()
        {
            Console.WriteLine("Write id:");

            var com = new DocumentRemoveCommand()
            {
                Id = Convert.ToInt32(Console.ReadLine())
            };

            var handler = new DocumentRemoveCommandHandler(fc, com);

            ce.Execute(handler);
        }
    }
}
