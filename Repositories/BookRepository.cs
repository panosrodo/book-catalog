using BookCatalog.Data;
using BookCatalog.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookCatalog.Repositories
{
    public class BookRepository : IBookRepository
    {
        private static List<Book> _books = new List<Book>();

        public IEnumerable<Book> GetAll() => _books;
        public Book? Get(int id) => _books.FirstOrDefault(b => b.Id == id);
        public void Add(Book book)
        {
            book.Id = _books.Count > 0 ? _books.Max(b => b.Id) + 1 : 1;
            _books.Add(book);
        }
        public void Update(Book book)
        {
            var existing = Get(book.Id);
            if (existing != null)
            {
                existing.Title = book.Title;
                existing.Author = book.Author;
                existing.Year = book.Year;
                existing.ISBN = book.ISBN;
            }
        }
        public void Delete(int id)
        {
            var book = Get(id);
            if (book != null) _books.Remove(book);
        }
    }
}