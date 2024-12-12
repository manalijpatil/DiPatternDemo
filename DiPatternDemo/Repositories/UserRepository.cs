using DiPatternDemo.Data;
using DiPatternDemo.Models;

namespace DiPatternDemo.Repositories
{
    public class UserRepository : IUserRepository

    {
        private readonly ApplicationDbContext db;
        public UserRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddUser(User user)
        {
          int result=0;
            db.Users.Add(user);
            result = db.SaveChanges();
            return result;
        }

        public int ValidateUser(User user)
        {
            var result = db.Users.Where(x => x.Email == user.Email && x.Password == user.Password);
            if (result != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
