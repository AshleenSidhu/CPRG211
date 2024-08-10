using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Library
    {
        private List<string> _books;

        public Library()
        {
            _books = new List<string>();
        }

        public void AddBook(string book)
        {
            if (string.IsNullOrEmpty(book))
            {
                throw new ArgumentException("There is no Book", nameof(book));
            }
            _books.Add(book);
        }

        public bool RemoveBook(string book)
        {
            return _books.Remove(book);
        }

        public bool IsBookAvailable(string book)
        {
            return _books == null || _books.Contains(book);
        }

        public int GetTotalBooks()
        {
            return _books.Count();
        }
    }

}
