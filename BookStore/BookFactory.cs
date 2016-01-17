using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;


namespace BookStore
{
    public static class BookFactory
    {   
        //public static List<Book> bookCatalog = new List<Book>();

        public static Book AddBookToCatalog(string isbn, string title, string author, int pubYear, decimal price)
        {
            using (var db = new BookModel())
            {
                var book = new Book();
                book.ISBN = isbn;
                book.Title = title;
                book.Author = author;
                book.PubYear = pubYear;
                book.Price = price;
                db.bookcatalog.Add(book);
                db.SaveChanges();
                return book;
            }
           
        }

        public static IEnumerable<Book> GetBookFromCatalog(string title)
        {
            var db = new BookModel();

            return db.bookcatalog.Where(a => a.Title == title);


        }



    }
}