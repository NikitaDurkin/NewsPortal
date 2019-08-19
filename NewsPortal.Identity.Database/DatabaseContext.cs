using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NewsPortal.Identity.Database.Models;

namespace NewsPortal.Identity.Database
{
    public class DatabaseContext : DbContext
    {
        private readonly IPasswordHasher<User> _passwordHasher = new PasswordHasher<User>();

        /// <summary />
        public DatabaseContext(DbContextOptions<DatabaseContext> options) :
            base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Заполнение базы пользователями
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var user = new User
            {
                Guid = Guid.NewGuid(), Login = "nikita@mail.ru", Password = "123456"
            };
            user.Password = _passwordHasher.HashPassword(user, user.Password);

            var user1 = new User
            {
                Guid = Guid.NewGuid(), Login = "ivan@mail.ru", Password = "654321"
            };
            user1.Password = _passwordHasher.HashPassword(user1, user1.Password);

            modelBuilder.Entity<User>().HasData(
                user,
                user1
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}