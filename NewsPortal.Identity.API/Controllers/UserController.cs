using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsPortal.Identity.Domain.Interfaces;
using NewsPortal.Identity.Domain.Models;

namespace NewsPortal.Identity.API.Controllers
{
    /// <summary>
    /// Контроллер пользователей
    /// </summary>
    [Route("api/user")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        /// <summary/>
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Регистрация пользователя
        /// </summary>
        /// <param name="registrationModel">Модель регистрации</param>
        /// <returns></returns>
        [Route("Register")]
        [HttpPost]
        public async Task<Guid> Registation([FromBody] RegistrationModel registrationModel)
        {
            return await _userService.Registration(registrationModel);
        }
    }
}