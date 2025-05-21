using Microsoft.EntityFrameworkCore;

namespace TodoBE.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        { }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Bucket> Buckets { get; set; }
        public DbSet<Task> Tasks { get; set; }

    }
}
