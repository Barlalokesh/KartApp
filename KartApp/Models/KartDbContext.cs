using Microsoft.EntityFrameworkCore;

namespace KartApp.Models
{

    public class KartDbContext:DbContext
    {
        public KartDbContext(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<Role> Roles { get; set; }
    }
}
