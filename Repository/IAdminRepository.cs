using Microsoft.AspNetCore.Http.HttpResults;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Collections.Generic;
using BookMyMovie.Models;

namespace BookMyMovie.Repository
{
    public interface IAdminRepository
    {
        IEnumerable<UserDto> GetAllUsers();
        Db_User? GetUserById(int user);
        void AddUser(UserDto user);
        void UpdateUser(UserDto user);
        void DeleteUser(int id);

        void Register(UserDto user);

        void Login(UserDto user);

        void Logout();

        void ForgotPassword(string email);
    }
}
