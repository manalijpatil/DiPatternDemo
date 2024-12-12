using DiPatternDemo.Models;
using DiPatternDemo.Repositories;

namespace DiPatternDemo.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repo;
        public UserService(IUserRepository repo) {
            this.repo = repo; 
        }
        public int AddUser(User user)
        {
            return repo.AddUser(user);
        }

        public int ValidateUser(User user)
        {
            return repo.ValidateUser(user);
        }
    }
}
