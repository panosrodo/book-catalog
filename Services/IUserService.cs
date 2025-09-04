using BookCatalog.Data;
using BookCatalog.Models;
using System.Collections.Generic;

namespace BookCatalog.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User? GetUserById(int id);
        User? GetUserByUsername(string username);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}