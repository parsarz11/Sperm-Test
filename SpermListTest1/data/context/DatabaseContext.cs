using Microsoft.EntityFrameworkCore;
using SpermListTest1.data.entites;

namespace SpermListTest1.data.context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions option) : base(option) 
        { 
        }

        public DbSet<fileDetails> fileDetails { get; set; }
        public DbSet<sperm> Sperms { get; set; }
    }
}
