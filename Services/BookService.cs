using BookCatalog.Data;
using BookCatalog.DTOs;
using BookCatalog.Models;
using BookCatalog.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace BookCatalog.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;
        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<BookDTO> GetAll() =>
            _repository.GetAll().Select(b => new BookDTO
            {
                Id = b.Id,
                Title = b.Title,
                Author = b.Author,
                Year = b.Year,
                ISBN = b.ISBN
            });

        public BookDTO? Get(int id)
        {
            var b = _repository.Get(id);
            return b == null ? null : new BookDTO
            {
                Id = b.Id,
                Title = b.Title,
                Author = b.Author,
                Year = b.Year,
                ISBN = b.ISBN
            };
        }

        public void Add(BookDTO book)
        {
            _repository.Add(new Book
            {
                Title = book.Title,
                Author = book.Author,
                Year = book.Year,
                ISBN = book.ISBN
            });
        }

        public void Update(BookDTO book)
        {
            _repository.Update(new Book
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                Year = book.Year,
                ISBN = book.ISBN
            });
        }

        public void Delete(int id) => _repository.Delete(id);
    }
}