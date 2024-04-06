using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem.Data
{
    public class UserService
    {
        private readonly AppDbContext _appDbContext;

        public UserService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<bool> AuthenticateUserAsync(User user)
        {
            User authenticatedUser = await _appDbContext.User.FirstOrDefaultAsync(c => c.Username.Equals(user.Username) && c.Password.Equals(user.Password));

            return authenticatedUser != null;
        }

    }
}

