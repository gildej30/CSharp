using Microsoft.EntityFrameworkCore;
using LoginReg.Models;

namespace LoginReg.Context
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions options) : base(options){}
        public DbSet<User> Users {get;set;}
    }
}