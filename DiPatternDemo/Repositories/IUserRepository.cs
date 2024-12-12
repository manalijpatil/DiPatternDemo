using DiPatternDemo.Models;

namespace DiPatternDemo.Repositories
{
    public interface IUserRepository
    {
        public int AddUser(User user);
        public int ValidateUser(User user);
    }
}
