using Microsoft.EntityFrameworkCore;

namespace Plate.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public DbSet<Task> tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=local.db");
        }
    }
}
