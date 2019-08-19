using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewsPortal.Identity.Domain.Interfaces;
using NewsPortal.Identity.Domain.Models;

namespace NewsPortal.Identity.API.Controllers
{
    /// <summary>
    /// Контроллер аутентификации и выдачи токена
    /// </summary>
    [Route(("api/authentication"))]
    [ApiController]
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authenticationService;

        /// <summary/>
        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        
        /// <summary>
        /// Аутентификация и выдача токена
        /// </summary>
        /// <param name="loginModel">Модель авторизации</param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Authenticate([FromBody] LoginModel loginModel)
        {
            var token = _authenticationService.Authenticate(loginModel);
            return Ok(token);
        }
    }
}