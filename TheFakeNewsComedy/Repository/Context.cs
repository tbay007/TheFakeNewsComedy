using System;
using Microsoft.EntityFrameworkCore;
namespace TheFakeNewsComedy.Repository
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public Context()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=MyDatabase.db");
        }
    }
}
