using Microsoft.EntityFrameworkCore;

namespace PreAcceleration.Data
{
    public class PreAccelerationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=DbChallengue;Trusted_Connection=True;");

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comments> Comments { get; set; }

    }
}
