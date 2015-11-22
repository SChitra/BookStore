using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    /// <summary>
    /// This class provides information about a book
    /// </summary>
    class Book
    {
      
        #region Properties
        public int Id { get; set; }
        /// <summary>
        /// Name of the Book
        /// </summary>
        public string Title { get; set; }
        public string Author { get; set; }
        public int PubYear { get; set; }
        /// <summary>
        /// Number of Books
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Price of a book
        /// </summary>
        public decimal Price { get; set; }
        #endregion

        #region Method
        /// <summary>
        /// Adding books to the inventory
        /// </summary>
        /// <param name="Qty"></param>
        /// <returns></returns>
        public int Add(int Qty)
        {
            Quantity += Qty;
            return Quantity;
        }
        /// <summary>
        /// Decreases the Quantity from the available quantity
        /// </summary>
        /// <param name="Qty"></param>
        /// <returns></returns>
        public int Reduce(int Qty)
        {
            Quantity -= Qty;
            return Quantity;
        }
        /// <summary>
        /// Check the available Quantity
        /// </summary>
        /// <returns></returns>
         public int CheckQuantity()
        {
            return Quantity;
        }
        /// <summary>
        /// Selling the book and reduces the available quantity
        /// </summary>
        /// <param name="Qty"></param>
        /// <returns></returns>
        public decimal Sell(int Qty)
        {
            decimal totalPrice = Price * Qty;
            Reduce(Qty);
            return totalPrice;

        }
        #endregion
    }


}
