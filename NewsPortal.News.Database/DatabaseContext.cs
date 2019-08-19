using System;
using Microsoft.EntityFrameworkCore;
using NewsPortal.News.Database.Models;

namespace NewsPortal.News.Database
{
    public class DatabaseContext : DbContext
    {
        /// <summary />
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Publications> Publications { get; set; }

        /// <summary>
        /// Заполнение базы новостями
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publications>().HasData(
                new Publications {Guid = Guid.NewGuid(), Title = "News1", Info = "qwertyuiop"}
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}