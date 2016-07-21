using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FakeContext
    {
        public List<Document> Documents = new List<Document>()
        {

            new Document()
            {
                DateTime = DateTime.Now,
                Id = 1,
                Name = "Doc1",
                Status = DocumentStatus.Draft,
            },
            new Document()
            {
                DateTime = DateTime.Now,
                Id = 2,
                Name = "Doc2",
                Status = DocumentStatus.Accepted,
            },
            new Document()
            {
                DateTime = DateTime.Now,
                Id = 3,
                Name = "Doc3",
                Status = DocumentStatus.Finished,
            },
            new Document()
            {
                DateTime = DateTime.Now,
                Id = 4,
                Name = "Doc4",
                Status = DocumentStatus.New,
            }
        };

        public void SaveChanges()
        {
        }
    }

}
