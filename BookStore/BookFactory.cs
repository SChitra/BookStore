using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public static class BookFactory
    {
        public static List<Book> bookCatalog = new List<Book>();

        public static void AddBookToCatalog(int isbn, string title, string author, int pubYear, decimal price)
        {
            var book = new Book();
            book.ISBN = isbn;
            book.Title = title;
            book.Author = author;
            book.PubYear = pubYear;
            book.Price = price;

            bookCatalog.Add(book);
        }

        public static Book GetBookFromCatalog(string title)
        {

            return bookCatalog.Find(item => item.Title.ToUpper() == title.ToUpper());

        }

    }
}