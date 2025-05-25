using UserService.Models;

namespace UserService.Repositories
{
    public interface IUserRepository
    {
         Task<User?> GetUserByIdAsync(string email);
         Task AddUserAsync(User user);
    }
}
