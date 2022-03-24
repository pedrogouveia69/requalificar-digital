using Microsoft.EntityFrameworkCore;

namespace Ficha14.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=ficha14;" +
                "user=root;password=password");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.HasKey(e => e.UserName);
                entity.HasKey(e => e.Password);
                entity.HasKey(e => e.Role);
                entity.HasKey(e => e.Email);
            });
        }
    }
}
