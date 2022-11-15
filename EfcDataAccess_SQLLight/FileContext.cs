using System.Text.Json;
using Domain.Models;
using FileData;
using Microsoft.EntityFrameworkCore;

namespace EfcDataAccess_SQLLight {
    public class FileContext : DbContext {
       
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<SubPage> SubPages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = ..\\EfcDataAccess\\DefinitelyReddit.db");
        }
   

       
    }
}
