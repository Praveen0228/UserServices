using Microsoft.EntityFrameworkCore;

namespace UserService.Data
{
    public class AuthDbContext: DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options)
            : base(options)
        {

        }
        public DbSet<Models.User> Users { get; set; }
    }
}
