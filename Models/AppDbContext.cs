using Microsoft.EntityFrameworkCore;
using N21__YP__Task_1_25._04._2025.Models;

namespace N21__YP__Task_1_25._04._2025
{
    public class AppDbContext : DbContext
    {
        public DbSet<Sotrud> Sotrud { get; set; }
        public DbSet<Clients> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Database.db");
        }
    }
}