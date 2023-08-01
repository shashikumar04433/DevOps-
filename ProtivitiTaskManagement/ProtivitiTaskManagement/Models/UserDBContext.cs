using Microsoft.EntityFrameworkCore;

namespace ProtivitiTaskManagement.Models
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Taask> Tasks { get; set; }
    }
}
