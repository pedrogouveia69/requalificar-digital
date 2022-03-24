using Ficha14.Models;

namespace Ficha14.Data
{
    public static class UsersDbInitializer
    {
        public static void InsertData(UserContext context)
        {          
            // Adds some books
            context.Users.Add(new User
            {
               
                UserName = "djardim",              
                Password = "qwerty",
                Role = "manager",
                Email = "djardim@gmail.com"
            });
            
            // Saves changes
            context.SaveChanges();
        }
    }
}