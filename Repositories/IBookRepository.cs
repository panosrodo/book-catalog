using BookCatalog.Data;
using BookCatalog.Models;
using System.Collections.Generic;

namespace BookCatalog.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();
        Book? Get(int id);
        void Add(Book book);
        void Update(Book book);
        void Delete(int id);
    }
}