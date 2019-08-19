using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace NewsPortal.Identity.Domain.Models
{
    /// <summary>
    /// Модель авторизации
    /// </summary>
    public class LoginModel
    {
        /// <summary />
        public LoginModel()
        {
        }

        /// <summary>
        /// Логин пользователя
        /// </summary>
        [Required]
        [JsonProperty("login")]
        public string Login { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        [Required]
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}