using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public enum BookFormat
    {
        Paperback =1,
        Kindle
    }
    /// <summary>
    /// This class provides information about a book
    /// </summary>
    public class Book
    {
      
 #region Properties
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PubYear { get; set; }
        public decimal Price { get; set; }
        public BookFormat TypeofEdition { get; set; }
 #endregion

       
    }


}
