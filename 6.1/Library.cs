using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1
{
    public class Library
    {
        private static Library instance;
        private List<Book> books;

        private Library()
        {
            books = new List<Book>();
        }

        public static Library Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Library();
                }
                return instance;
            }
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> GetBooks()
        {
            return books;
        }
    }
}
