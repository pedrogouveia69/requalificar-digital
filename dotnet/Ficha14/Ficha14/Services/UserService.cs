using Ficha14.Models;

namespace Ficha14.Services
{
    public class UserService : IUserService
    {
        private readonly UserContext context;
        public UserService(UserContext context)
        {
            this.context = context;
        }

        public User Create(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user;

        }

        public User FindByName(string userName)
        {
            var user = context.Users.FirstOrDefault(u => u.UserName == userName);
            return user;
        }

        public User? Get(string userName, string password)
        {
            var user = context.Users.FirstOrDefault(u => u.UserName == userName && u.Password == password);
            return user;
        }
    }
}
