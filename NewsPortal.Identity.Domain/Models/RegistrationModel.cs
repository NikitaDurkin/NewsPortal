using System.ComponentModel.DataAnnotations;

namespace NewsPortal.Identity.Domain.Models
{
    /// <summary>
    /// Модель регистрации
    /// </summary>
    public class RegistrationModel
    {
        /// <summary />
        public RegistrationModel()
        {
        }

        /// <summary>
        /// Логин пользователя
        /// </summary>
        [Required]
        public string Login { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}