using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_Module
{
    
    internal class Combined
    {
        Dictionary<string, List<Book>> dictioary;
        public Combined()
        {
            this.dictioary = new Dictionary<string, List<Book>>();
        }

        public void fillDictionary()
        {
            //List<Book> bookListOne = new List<Book>();
            //List<Book> bookListOne = new List<Book>();

            dictioary.Add("Policy",new List<Book>());
            dictioary.Add("Novel", new List<Book>());

            dictioary["Policy"].Add(new Book("book1", "author1"));
            dictioary["Policy"].Add(new Book("book2", "author2"));
            dictioary["Policy"].Add(new Book("book3", "author3"));

            dictioary["Novel"].Add(new Book("book4", "autor4"));
            dictioary["Novel"].Add(new Book("book5", "author5"));
            dictioary["Novel"].Add(new Book("book6", "author6"));


        }

        public void deleteBoock()
        {
            foreach(Book book in dictioary["Novel"])
            {
                if (book.name == "book4") dictioary["Novel"].Remove(book);
            }

        }

        public void listInSpecificGender(string gender)
        {
            switch (gender)
            {
                case "Policy":
                    foreach(Book book in dictioary["Policy"])
                    {
                        Console.WriteLine($"Book Name: {book.name} Book Author: {book.author}");
                    }
                    break;

                case "Novel":
                    foreach (Book book in dictioary["Novel"])
                    {
                        Console.WriteLine($"Book Name: {book.name} Book Author: {book.author}");
                    }
                    break;

            }
        }


        public void listGroupedByGender()
        {
            foreach(var library in dictioary)
            {
                string genderLibary = library.Key;

                foreach (Book book in dictioary[genderLibary])
                {
                    Console.WriteLine($"Book Name: {book.name} Book Author: {book.author}");
                }
                break;
            }


        }

    }
}
