using ProdsNCats.Models;
using Microsoft.EntityFrameworkCore;

namespace ProdsNCats.Context
{
    public class HomeContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public HomeContext(DbContextOptions options) : base(options) { }
        public DbSet<Category> Categories {get;set;}
        public DbSet<Product> Products {get; set;}
        public DbSet<Association> Associations {get; set;}
    }
}