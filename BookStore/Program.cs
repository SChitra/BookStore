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
            var myBook = new Book();
            myBook.Id = 1;
            myBook.Title = "Harry Potter";
            myBook.Author = "ff";
            myBook.PubYear = 2010;
            myBook.Quantity = 5;
            myBook.Price = 10;

            int UpdatedQuantity = myBook.Add(2);
            Console.WriteLine("Number of my Books available {0} ", myBook.CheckQuantity());

            decimal totalCost = myBook.Sell(3);
            Console.WriteLine("Sold Amount {0}", totalCost);
            
            Console.WriteLine("Number of my Books available  {0} ",myBook.CheckQuantity());
           
            Console.ReadLine();

        }
    }
}
