using System;
using CQRS.Abstraction;
namespace Model
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public DocumentStatus Status { get; set; }
    }
     
}
