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

            BookFactory.AddBookToCatalog("123-456-789", "Learning c#", "Jessie Liberty", 2008, 25.0m);
            BookFactory.AddBookToCatalog("111-222-333","Harry Potter", "JK Rowling", 2014, 30.0m);
            BookFactory.AddBookToCatalog("456-c425-pp44","Red Queen", "Victoria", 2013, 15.0m);
            BookFactory.AddBookToCatalog("984-op3-123p","Illustrated c#", "Daniel Solis", 2012, 45.45m);


            Console.WriteLine("*****Online Book Store*****");
            Console.WriteLine();
           // Console.WriteLine("Books available in store now");

            ////foreach (var book in BookFactory.bookCatalog)
            //{
            //    Console.WriteLine(book.ISBN.ToString() + "  " + book.Title + "  " + book.Author + "  " + book.PubYear + "  " + book.Price);
            //}
            Console.WriteLine();
            Console.Write("Please enter the title of the book you are searching for:" );
            string bookTitle = Console.ReadLine();

            var bk1 = BookFactory.GetBookFromCatalog(bookTitle);
            Console.WriteLine("Product Details ");
            foreach (var bk in bk1)
            {
                Console.WriteLine("ISBN: {0}, \nBook Title : {1}, \nBook Author: {2}, \nPrice: {3}, \nPubYear: {4}",bk.ISBN, bk.Title, bk.Author, bk.Price, bk.PubYear);
             }
            // Console.WriteLine("Book Title : {0}, Book Author: {1}, Price: {2}, PubYear: {3}", bk1.FirstOrDefault().Title, bk1.FirstOrDefault().Author, bk1.FirstOrDefault().PubYear, bk1.FirstOrDefault().Price);

            Console.ReadLine();
           
        }
    }
}
