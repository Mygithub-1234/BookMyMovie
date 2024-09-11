using BookMyMovie.Models;

namespace BookMyMovie.Services
{
    public interface IAdminService
    {
        IEnumerable<UserDto> GetAllUsers();
        Customer? GetUserById(int user);
        void AddUser(UserDto user);
        void UpdateUser(UserDto user);
        void DeleteUser(int id);

        void Register(UserDto user);

        void Login(UserDto user);

        void Logout();

        void ForgotPassword(string email);
    }
}
