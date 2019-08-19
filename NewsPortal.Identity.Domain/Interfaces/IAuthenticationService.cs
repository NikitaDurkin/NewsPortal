using NewsPortal.Identity.Domain.Models;

namespace NewsPortal.Identity.Domain.Interfaces
{
    /// <summary>
    /// Сервис аутентификации и выдачи токена
    /// </summary>
    public interface IAuthenticationService
    {
        /// <summary>
        /// Аутентификация и выдача токена
        /// </summary>
        /// <param name="loginModel">Модель авторизации</param>
        /// <returns></returns>
        string Authenticate(LoginModel loginModel);
    }
}