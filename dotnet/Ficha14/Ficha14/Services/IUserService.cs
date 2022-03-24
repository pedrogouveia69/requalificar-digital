using Ficha14.Models;

namespace Ficha14.Services
{
    public interface IUserService
    {
        public abstract User? Get(string userName, string password);
        public abstract User Create(User user);

        public abstract User FindByName(string name);
    }
}
