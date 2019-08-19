using System;
using System.Threading.Tasks;
using NewsPortal.Identity.Domain.Models;

namespace NewsPortal.Identity.Domain.Interfaces
{
    /// <summary>
    /// Сервис по работе с пользователями
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Проверка существования пользователя
        /// </summary>
        /// <param name="login">Логин пользователя</param>
        /// <param name="password">Пароль пользователя</param>
        /// <returns></returns>
        Task<bool> ValidateUser(string login, string password);

        /// <summary>
        /// Регистрация пользователя
        /// </summary>
        /// <param name="registrationModel">Модель регистрации</param>
        /// <returns></returns>
        Task<Guid> Registration(RegistrationModel registrationModel);
    }
}