using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambaExpression2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> {"Ratna", "Pial", "Jitu"};
            string found = names.Find(name => name.StartsWith("R"));
            Console.WriteLine(found);
            List<string> f = names.FindAll(n => n.Contains("a"));
            foreach (var VARIABLE in f)
            {
                Console.WriteLine(VARIABLE);
            }
                 List<Book> books = new List<Book> { 
                new Book { Author="Mcconnell",Name="Code Complete", Published=new DateTime(1993,05,14) },
                new Book { Author="Sussman",Name="SICP (2nd)", Published=new DateTime(1996,06,01) },
                new Book { Author="Hunt",Name="Pragmatic Programmer", Published=new DateTime(1999,10,30) },
            };

            var selectedBooks = books.FindAll(book => book.Published > (new DateTime(1995, 12, 31)));

            foreach (var book in selectedBooks)
            {
                Console.WriteLine(book.Author);
            }
            List<double> values = new List<double>() { 4, 5, 77, 15, 3, 25 };
            double aNumber = values.Find(number => (number >= 10));
            Console.WriteLine(aNumber);
            Console.ReadKey();
        }
    }
}
