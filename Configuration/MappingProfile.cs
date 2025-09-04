using AutoMapper;
using BookCatalog.Data;
using BookCatalog.DTOs;
using BookCatalog.Models;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Book, BookDTO>().ReverseMap();
        CreateMap<User, UserDTO>().ReverseMap();
    }
}