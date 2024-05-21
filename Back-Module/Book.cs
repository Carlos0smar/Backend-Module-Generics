using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_Module
{
    
    internal class Book
    {
        public string name { get; set; }
        public string author { get; set; }
        public Book(string name, string author) {
            
            this.name = name;
            this.author = author;
        }
    }
}
