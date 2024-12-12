using DiPatternDemo.Models;

namespace DiPatternDemo.Services
{
    public interface IUserService
    {
        public int AddUser(User user);
        public int ValidateUser(User user);
    }
}
