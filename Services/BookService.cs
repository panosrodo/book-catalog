using AutoMapper;
using BookCatalog.Data;
using BookCatalog.DTOs;
using BookCatalog.Models;
using BookCatalog.Repositories;
using System.Collections.Generic;

namespace BookCatalog.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<BookDTO> GetAll() =>
            _mapper.Map<IEnumerable<BookDTO>>(_repository.GetAll());

        public BookDTO? Get(int id)
        {
            var b = _repository.Get(id);
            return b == null ? null : _mapper.Map<BookDTO>(b);
        }

        public void Add(BookDTO book)
        {
            var entity = _mapper.Map<Book>(book);
            _repository.Add(entity);
        }

        public void Update(BookDTO book)
        {
            var entity = _mapper.Map<Book>(book);
            _repository.Update(entity);
        }

        public void Delete(int id) => _repository.Delete(id);
    }
}