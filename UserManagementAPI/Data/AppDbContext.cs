using Microsoft.EntityFrameworkCore;
using UserManagementAPI.Models;

namespace UserManagementAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Sẽ thêm DbSet<> ở đây sau khi có model
        
        public DbSet<User> Users {get; set;}
    }

    
}
