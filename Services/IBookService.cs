using System.Collections.Generic;
using BookCatalog.DTOs;

namespace BookCatalog.Services
{
    public interface IBookService
    {
        IEnumerable<BookDTO> GetAll();
        BookDTO? Get(int id);
        void Add(BookDTO book);
        void Update(BookDTO book);
        void Delete(int id);
    }
}