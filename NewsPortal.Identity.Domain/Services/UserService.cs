using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NewsPortal.Identity.Database;
using NewsPortal.Identity.Database.Models;
using NewsPortal.Identity.Domain.Interfaces;
using NewsPortal.Identity.Domain.Models;

namespace NewsPortal.Identity.Domain.Services
{
    /// <inheritdoc/>
    public class UserService : IUserService
    {
        private readonly DatabaseContext _context;
        private readonly IPasswordHasher<User> _passwordHasher = new PasswordHasher<User>();

        /// <summary/>
        public UserService(DatabaseContext context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public async Task<bool> ValidateUser(string login, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(b => b.Login == login);

            var result = _passwordHasher.VerifyHashedPassword(user, user.Password, password);

            return result == PasswordVerificationResult.Success;
        }

        /// <inheritdoc/>
        public async Task<Guid> Registration(RegistrationModel registrationModel)
        {
            var user = new User
            {
                Guid = Guid.NewGuid(),
                Login = registrationModel.Login
            };
            user.Password = _passwordHasher.HashPassword(user, registrationModel.Password);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user.Guid;
        }
    }
}