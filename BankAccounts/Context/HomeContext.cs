using Microsoft.EntityFrameworkCore;
using BankAccounts.Models;

namespace BankAccounts.Context
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions options) : base(options){}
        public DbSet<User> Users {get;set;}

        public DbSet<Transaction> Transactions {get; set;}
    }
}