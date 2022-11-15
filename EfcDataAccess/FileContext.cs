using System.Text.Json;
using Domain.Models;
using FileData;
using Microsoft.EntityFrameworkCore;


namespace EfcDataAccess {
    public class FileContext : DbContext {
        
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<SubPage> SubPages {get; set;}
/*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=mouse.db.elephantsql.com;Port=5432;Database=etycxoez;Username=etycxoez;Password=GxZdfusKyEph5RDtyEAIgDvg_BjpljQf",
                options => options.UseAdminDatabase("etycxoez"));
                
        }
       */

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=mouse.db.elephantsql.com;Port=5432;Database=etycxoez;Username=etycxoez;Password=GxZdfusKyEph5RDtyEAIgDvg_BjpljQf");
    }
        

       
        
}
