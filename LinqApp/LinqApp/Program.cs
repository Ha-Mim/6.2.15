using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
             List<Book> books = new List<Book>()
                                   {
                                      new Book{Title = "Prejudice", Price = 1300},
                                      new Book{Title = "Justice", Price = 3000},
                                      new Book{Title = "War & Peace", Price = 1700},
                                      new Book{Title = "Computer Programming", Price = 700}
                                   };
            var selectedBooks = from book in books
                        where book.Price > 1000
                        select book;
            var select = from book in books
                where book.Price < 1000
                select book;
            foreach (var book in select)
            {
              //  Console.WriteLine(book.Title);
            }

            var sbooks = books.Where(book => book.Price > 1000);
            IEnumerable<string> bookList = books.Where(book => book.Title.Contains("C")).Select(jug => jug.Title);
            // IEnumerable<string> bookList = books.Where(book => book.Title.Contains("P")).Select(title => title.Title);
            foreach (string title in bookList)
            {
                //Console.WriteLine(title);
            }

            foreach (Book aBook in selectedBooks)
            {
                //Console.WriteLine(aBook.Title);
            }

            // Anonymous magic
            Method1();

            Console.ReadKey();
        }

        private static void Method1()
        {
            var books = new[]
                                   {
                                      new {Title = "Prejudice", Price = 1300},
                                      new {Title = "Justice", Price = 3000},
                                      new {Title = "War & Peace", Price = 1700},
                                      new {Title = "Computer Programming", Price = 700}
                                   };
            var selectedBooks = from book in books
                                where book.Price == 1300
                                select book;

            foreach (var aBook in selectedBooks)
            {
                Console.WriteLine(aBook.Title);
            }
        }
        }
    }

