using BookMyMovie.Models;

namespace BookMyMovie.Repository
{
    public class AdminRepository : IAdminRepository
    {
        public void AddUser(UserDto user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public void ForgotPassword(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Customer? GetUserById(int user)
        {
            throw new NotImplementedException();
        }

        public void Login(UserDto user)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public void Register(UserDto user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserDto user)
        {
            throw new NotImplementedException();
        }
    }
}
