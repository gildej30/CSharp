using Microsoft.EntityFrameworkCore;
namespace FirstEntity.Models
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users {get;set;}
    }
}