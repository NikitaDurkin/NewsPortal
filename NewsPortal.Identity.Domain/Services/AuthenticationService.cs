using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using NewsPortal.Identity.Database.Models;
using NewsPortal.Identity.Domain.Interfaces;
using NewsPortal.Identity.Domain.Models;

namespace NewsPortal.Identity.Domain.Services
{
    /// <inheritdoc/>
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserService _userService;
        private readonly TokenManagement _tokenManagement;

        /// <summary/>
        public AuthenticationService(IUserService userService, IOptions<TokenManagement> tokenManagement)
        {
            _userService = userService;
            _tokenManagement = tokenManagement.Value;
        }

        /// <inheritdoc/>
        public string Authenticate(LoginModel loginModel)
        {
            if (!_userService.ValidateUser(loginModel.Login, loginModel.Password).Result)
                return null;
            var claim = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, loginModel.Login)
            };

            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_tokenManagement.Secret));

            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var jwtToken = new JwtSecurityToken(
                _tokenManagement.Audience,
                _tokenManagement.Issuer,
                claim,
                expires: DateTime.Now.AddMinutes(_tokenManagement.AccessExpiration),
                signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }
    }
}