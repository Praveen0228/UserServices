using Microsoft.EntityFrameworkCore;
using UserService.Data;
using UserService.Models;

namespace UserService.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AuthDbContext _authDbContext;
        public UserRepository(AuthDbContext authDbContext) {
            _authDbContext = authDbContext;
        }

        public Task<User?> GetUserByIdAsync(string email) => _authDbContext.Users.FirstOrDefaultAsync(x => x.Email == email);
       
        public async Task AddUserAsync(User user)
        {
            await _authDbContext.Users.AddAsync(user);
            await _authDbContext.SaveChangesAsync();
        }

    }
}
