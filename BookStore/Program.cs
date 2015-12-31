using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Program
    {
        static void Main(string[] args)
        {
           
            BookFactory.AddBookToCatalog(1111, "Learning c#", "Jessie Liberty", 2008, 25.0m);
            BookFactory.AddBookToCatalog(2222, "Harry Potter", "JK Rowling", 2014, 30.0m);
            BookFactory.AddBookToCatalog(3333, "Red Queen", "Victoria", 2013, 15.0m);
            BookFactory.AddBookToCatalog(4444, "Illustrated c#", "Daniel Solis", 2012, 45.45m);


            Console.WriteLine("*****Online Book Store*****");
            Console.WriteLine();
            Console.WriteLine("Books available in store now");

            foreach (var book in BookFactory.bookCatalog)
            {
                Console.WriteLine(book.ISBN.ToString() + "  " + book.Title + "  " + book.Author + "  " + book.PubYear + "  " + book.Price);
            }
            Console.WriteLine();
            Console.Write("Please enter the title of the book you are searching for:" );
            string bookTitle = Console.ReadLine();

            Book bk1 = BookFactory.GetBookFromCatalog(bookTitle);
            Console.WriteLine("Product Details ");
            Console.WriteLine("{0} \nby {1} \nISBN :{2} \nPrice:{3} \nPublication Year:{4}", bk1.Title, bk1.Author, bk1.ISBN, bk1.Price,bk1.PubYear);

                                   
            Console.ReadLine();

        }
    }
}
