using Microsoft.EntityFrameworkCore;
using nidos.API.Model;

namespace nidos.API
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        
    }
}