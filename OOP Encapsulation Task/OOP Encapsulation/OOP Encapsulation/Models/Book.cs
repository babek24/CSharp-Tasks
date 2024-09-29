using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsulation.Models
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Page { get; set; }

        public Book(string Name, string Author, int Page)
        {
            this.Name = Name;
            this.Author = Author;
            this.Page = Page;
        }
    }

    
}
