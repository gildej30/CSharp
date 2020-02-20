using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;

namespace WeddingPlanner.Context
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions options) : base(options){}
        public DbSet<User> Users {get;set;}

        public DbSet<Wedding> Weddings {get;set;}
        public DbSet<RSVP> Rsvps {get;set;}
    }
}